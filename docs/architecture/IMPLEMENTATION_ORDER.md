# Time Wallpaper — IMPLEMENTATION_ORDER.md

**Status:** Frozen

## Phase 0 — Repository Foundation

- legacy/WDD
- new solution
- projects
- x64 + ARM64
- Windows 10 22H2 minimum
- CI
- license notices

验收：

- x64 builds
- ARM64 builds
- no circular refs
- Agent !→ App
- Agent !→ AI
- Core no WinUI

## Phase 1 — Core + Solar Engine

实现：

- SolarPhase
- IClock
- SolarSchedule
- ISolarScheduleService
- timezone-aware rules
- current / next phase
- polar fallback
- pause model

测试：

- summer / winter
- latitude
- DST
- timezone change
- midnight
- exact boundary
- polar day/night

## Phase 2 — Theme Engine

实现：

- ThemeDefinition
- `.twtheme`
- ZIP
- manifest
- Validator
- Safe Area
- Focal Point
- install/update/remove
- WDD importer
- path traversal protection
- unsafe file rejection

测试 2/4/8/16/24-image WDD themes。

## Phase 3 — Windows Wallpaper Platform

实现：

- IWallpaperService
- IDisplayService
- persistent monitor identity
- IDesktopWallpaper
- topology events
- sleep/resume
- unlock
- system time / timezone

先做 CLI/test harness。

## Phase 4 — Renderer + Content

实现：

- Crop
- Focal Point
- Safe Area
- Text Renderer
- Auto color
- Shadow
- Opacity
- Render Profiles
- Cache
- Poetry / English
- Solar Terms / Holidays

Renderer 必须被 Desktop / Home / Settings / Studio Preview 共用。

## Phase 5 — Agent

实现：

- Agent bootstrap
- Tray
- Settings / State
- Reconciliation
- Scheduling
- Pause / Resume
- Sleep / Resume
- Unlock
- Display changes
- IPC
- Startup

Phase 5 结束时：没有 WinUI 也能完整运行。

性能目标：

- idle CPU ≈ 0
- no continuous GPU
- memory target 20–40MB

## Phase 6 — WinUI App

顺序：

1. Shell
2. Design Tokens
3. Navigation
4. Onboarding
5. Home
6. Daily Content
7. Location
8. Displays
9. Settings
10. Themes
11. Theme Detail

## Phase 7A — Theme Studio

- Studio Home
- ThemeDraft
- 1–8 image import
- filename sorting
- phase strip
- drag / swap / move
- Focal Point
- Safe Area
- Draft Recovery
- Preview
- Save / Export / Clone

固定：

- Inspector 312px
- Phase Strip 120px

## Phase 7B — Theme Store

- index
- HTTPS
- SHA-256
- categories
- search
- download
- install
- update
- third-party sources

离线时 Installed Themes 仍完全可用。

## Phase 7C — AI Dynamic

- AI Service settings
- reference image
- target ratio
- optional instructions
- 8 phases
- concurrency 2
- phase status
- retry/regenerate
- partial success
- recovery draft
- continue to Studio

## Phase 8 — Distribution & Hardening

Store：

- MSIX Bundle
- x64 + ARM64
- framework-dependent

GitHub：

- EXE x64
- EXE ARM64
- self-contained

Release 前检查：

- secrets
- logs
- theme safety
- location privacy
- sleep/resume
- monitor reconnect
- primary switch
- UI crash
- Agent restart
- reboot
- localization
- performance
