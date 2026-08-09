# Time Wallpaper — ARCHITECTURE.md

**Status:** Frozen

## Repository

```text
TimeWallpaper/
├── legacy/WinDynamicDesktop/
├── src/
│   ├── TimeWallpaper.App/
│   ├── TimeWallpaper.Agent/
│   ├── TimeWallpaper.Core/
│   ├── TimeWallpaper.Platform.Windows/
│   ├── TimeWallpaper.Rendering/
│   ├── TimeWallpaper.Themes/
│   ├── TimeWallpaper.Content/
│   └── TimeWallpaper.AI/
├── tests/
└── docs/
```

## App

WinUI 3 / MVVM。

负责：

- UI
- navigation
- onboarding
- themes
- studio
- settings
- AI UI

不负责平台 API / Solar / Renderer 业务实现。

## Agent

长期后台进程。

负责：

- tray
- scheduler
- reconciliation
- sleep/resume
- unlock
- display events
- pause/resume

禁止：

- Agent → App
- Agent → AI
- Agent → WinUI

## Core

平台无关：

- Solar domain
- settings/state models
- scheduling rules
- daily content rules
- assignment rules
- cache key models

禁止引用 Windows / UI。

## Platform.Windows

封装：

- IDesktopWallpaper
- displays
- Windows Location
- system events
- startup
- file association
- distribution
- secret store
- app paths

## Rendering

负责：

- image decode
- crop
- Focal Point
- Safe Area
- text
- auto color
- shadow
- preview
- final wallpaper
- cache

Renderer 是 Desktop / Home / Settings / Studio Preview 的唯一视觉真相。

## Themes

负责：

- `.twtheme`
- ThemeDefinition
- validator
- install/update/remove
- WDD importer
- Store index
- SHA-256
- ThemeDraft / ownership

## Content

- Poetry
- English
- Solar Terms
- Holidays

本地运行，无每日网络依赖。

## AI

- IImageGenerationProvider
- generation queue
- phase state

Agent 不引用 AI。

## Dependency Direction

```text
                 App
          ┌──────┼──────┐
          ▼      ▼      ▼
       Themes Rendering Platform
          │      │      │
          └──────┼──────┘
                 ▼
                Core
                 ▲
                 │
              Content

                Agent
          ┌──────┼──────┐
          ▼      ▼      ▼
       Themes Rendering Platform
          └──────┼──────┘
                 ▼
                Core

App → AI
```

## App / Agent IPC

App：

- save Settings
- notify Agent Reload
- request refresh/pause/resume/status

Agent 自己 reconcile。

## Settings vs State vs Secrets

- Settings = user intent
- State = runtime
- Secrets = sensitive

不可混合。

## Event-driven

Agent 不做：

- 1-second timer
- 1-minute polling
- continuous location
- continuous Theme Store polling

## Reconciliation

重要事件后：

```text
Read current inputs
→ Calculate desired state
→ Compare actual state
→ Apply only correction
→ Schedule next event
```

睡眠错过阶段后直接进入当前正确阶段，不 replay。

## IClock

Core scheduling 不直接依赖 `DateTime.Now`。

## Error Isolation

- Theme Store offline → installed themes work
- AI failure → manual Studio works
- location refresh failure → cached/manual remains
- UI crash → Agent continues

## Licensing

- WDD reused code保留 MPL notice
- Auto Dark Mode 仅参考设计，不复制 GPL 实现
