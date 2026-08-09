# Time Wallpaper — IMPLEMENTATION_ORDER.md

**Status:** Frozen

## Phase 0 — Repository Foundation

- new solution
- projects
- x64 / ARM64
- Win10 22H2 minimum
- CI
- architecture boundaries
- license

验收：

- Agent !→ App
- Agent !→ AI
- Core no WinUI
- no circular references

## Phase 1 — Core + Solar Engine

- SolarPhase
- IClock
- location domain
- SolarSchedule
- ISolarScheduleService
- phase resolver
- high-latitude fallback
- timezone
- midnight
- pause model

必须先大量单测。

## Phase 2 — Theme Engine

- ThemeDefinition
- `.twtheme`
- ZIP
- manifest
- validator
- path traversal protection
- Focal Point
- Safe Area
- install/update/remove
- WDD importer

## Phase 3 — Windows Platform

- IWallpaperService
- IDisplayService
- PersistentMonitorId
- IDesktopWallpaper
- topology
- sleep/resume
- unlock
- system time / timezone

先做 CLI/test harness。

## Phase 4 — Renderer + Content

- Crop
- Focal Point
- Safe Area
- text
- auto color
- shadow
- cache
- Poetry / English
- Solar Terms / Holidays

Renderer 必须统一 Desktop / UI Preview。

## Phase 5 — Agent

- tray
- reconciliation
- event scheduler
- settings/state
- IPC
- pause
- sleep/resume
- display changes
- startup

Phase 5 完成时，无 WinUI 也应该可完整运行。

## Phase 6 — WinUI

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

- ThemeDraft
- 1–8 images
- drag/swap/move
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
- categories
- search
- HTTPS
- SHA-256
- install/update
- third-party sources

## Phase 7C — AI Dynamic

- AI Service
- reference image
- target ratio
- optional instructions
- 8 phases
- concurrency 2
- retry/regenerate
- partial success
- recovery draft

## Phase 8 — Distribution

Store：

- MSIX Bundle
- x64 + ARM64
- framework-dependent

GitHub：

- EXE x64
- EXE ARM64
- self-contained

Release review：

- privacy
- logs
- secrets
- theme safety
- sleep/resume
- monitor reconnect
- performance
- localization
