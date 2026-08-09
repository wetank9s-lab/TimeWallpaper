# Time Wallpaper — V0_1_SCOPE.md

**Status:** Frozen

## Core

必须交付：

- Solar Timeline
- 8 official phases
- high-latitude fallback
- timezone handling
- daily content stability
- solar terms
- holidays
- Settings / State

## Platform

- IDesktopWallpaper
- displays
- persistent monitor identity
- Windows Location
- sleep / resume
- unlock
- topology events
- startup
- `.twtheme` activation

## Agent

- tray
- event-driven scheduling
- pause / resume
- refresh
- wallpaper reconciliation
- startup execution
- IPC

## Theme Engine

- `.twtheme`
- manifest
- validator
- themeId + version
- Focal Point
- Safe Area
- install / update / remove
- WDD importer
- SHA-256

## Renderer

- per-monitor crop
- Focal Point
- Safe Area
- poetry / English / holiday
- auto text color
- opacity
- shadow
- cache
- preview

## UI

必须完成：

- Onboarding
- Home
- Themes
- Theme Detail
- Daily Content
- Location
- Displays
- Settings
- Studio Home
- Theme Studio
- AI Dynamic
- AI Service Settings

## Built-in

主题：

- 山湖
- 建筑
- 天空

内容：

- Curated Desktop Poetry
- Elegant English Words
- Solar Terms
- Holidays

## AI

- Reference image
- target ratio
- optional instructions
- 8 phases
- concurrency = 2
- phase-level state
- retry
- regenerate candidate
- manual replace
- partial success
- recovery draft

## Distribution

Store：

- MSIX Bundle
- x64 + ARM64
- framework-dependent

GitHub：

- EXE x64
- EXE ARM64
- self-contained

## Definition of Done

V0.1 必须同时满足：

- Core reliable
- Agent reliable
- Sleep / Resume reliable
- Multi-monitor reliable
- Theme package safe
- Renderer consistent
- Privacy rules satisfied
- No hidden continuous background work
