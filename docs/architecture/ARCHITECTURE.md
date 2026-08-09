# Time Wallpaper — ARCHITECTURE.md

**Status:** Frozen  
**Version:** V0.1

## 1. Repository

```text
TimeWallpaper/
├── legacy/
│   └── WinDynamicDesktop/
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

## 2. Responsibilities

### App

WinUI 3 / MVVM。

负责：

- Navigation
- Onboarding
- Home
- Themes
- Daily Content
- Location
- Displays
- Settings
- Theme Studio
- AI UI

不负责：

- Solar 算法
- Wallpaper API
- Theme 解析
- Registry
- COM
- 直接业务文件系统操作

### Agent

长期后台进程。

负责：

- Tray
- Scheduler
- Sleep / Resume
- Unlock
- Display topology
- Pause / Resume
- Wallpaper reconciliation
- Startup runtime

禁止引用：

- App
- WinUI
- AI

### Core

平台无关业务规则：

- SolarPhase
- SolarSchedule
- Settings / State models
- Daily content rules
- Holidays
- Assignment rules
- Cache key models

禁止引用 Windows API / UI。

### Platform.Windows

封装 Windows：

- IDesktopWallpaper
- Monitor enumeration
- Persistent monitor identity
- Windows Location
- Network events
- Startup
- File associations
- Store / distribution
- Secret storage

### Rendering

负责：

- Decode
- Crop
- Focal Point
- Safe Area
- Daily content rendering
- Auto text color
- Shadow / Opacity
- Preview
- Render Cache

Renderer 是桌面、首页、设置预览、Studio Preview 的唯一视觉真相。

### Themes

负责：

- `.twtheme`
- ThemeDefinition
- Validator
- Install / Update / Remove
- WDD importer
- Store index
- SHA-256
- Theme ownership
- Draft

### Content

本地精选数据：

- Poetry
- English Words
- Solar Terms
- Holidays

### AI

只负责可选图像生成：

- IImageGenerationProvider
- Generation queue
- Session
- Phase-level states

Agent 不引用 AI。

## 3. Dependency Direction

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

禁止：

- Core → App
- Core → Agent
- Agent → App
- Agent → AI
- Rendering → App
- Themes → App
- 循环依赖

## 4. Agent Runtime

事件驱动，不轮询。

```text
Start
→ Load Settings/State
→ Resolve Displays
→ Resolve Location
→ Calculate Solar
→ Resolve Phase
→ Resolve Theme
→ Resolve Render
→ Apply
→ Schedule next event
→ Sleep
```

唤醒事件：

- Next Solar Phase
- Sleep / Resume
- Unlock
- Display change
- Primary monitor change
- Timezone / system time change
- Settings change
- Manual refresh

## 5. Solar Service

输入：

- Date
- Latitude
- Longitude
- Timezone

输出：

- Dawn
- Sunrise
- Morning
- Noon
- Afternoon
- Sunset
- Dusk
- Night
- CurrentPhase
- NextPhase
- NextTransition
- FallbackUsed

Core 中必须可测试。

## 6. Theme Normalization

```text
WDD Theme
→ WddThemeImporter
→ ThemeDefinition

.twtheme
→ TwThemeReader
→ ThemeDefinition
```

Runtime 不包含旧格式特例。

## 7. App ↔ Agent

通过 IPC。

建议契约：

- RefreshWallpaper
- Pause
- Resume
- ReloadSettings
- ReloadThemeAssignments
- RefreshDisplays
- GetRuntimeStatus

App 保存 Settings 后通知 Agent Reload，Agent 自己 reconcile。

## 8. Reconciliation

任何重要事件：

```text
Read current inputs
→ Calculate desired state
→ Compare Windows state
→ Apply only required correction
→ Schedule next event
```

睡眠错过多个阶段时直接进入当前正确阶段，不补放历史阶段。

## 9. Time Abstraction

Core 不应到处调用 `DateTime.Now`。

使用 `IClock` 或等价抽象以测试：

- DST
- midnight
- phase boundary
- sleep/resume

## 10. Error Isolation

- Theme Store offline → installed themes still work
- Location refresh fails → cached/manual location continues
- AI fails → manual Studio continues
- Preview fails → Agent runtime continues

## 11. Licensing

- WDD reused code保留 MPL notice
- Auto Dark Mode 只参考交互与 Fluent 组件选择
- 不复制 GPL 实现
