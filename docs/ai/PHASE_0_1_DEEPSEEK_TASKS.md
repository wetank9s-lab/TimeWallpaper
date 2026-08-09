# Time Wallpaper — PHASE_0_1_DEEPSEEK_TASKS.md

**Status:** Ready for Implementation

## Task 01 — Solution Skeleton

创建：

- App
- Agent
- Core
- Platform.Windows
- Rendering
- Themes
- Content
- AI
- test projects

要求：

- x64
- ARM64
- Win10 22H2+
- Agent !→ App
- Agent !→ AI
- Core no WinUI
- no product features yet

## Task 02 — Architecture Guards

检查禁止项目引用。

不引入架构测试 NuGet，除非批准。

## Task 03 — SolarPhase

Enum：

- Dawn
- Sunrise
- Morning
- Noon
- Afternoon
- Sunset
- Dusk
- Night

不含 UI 文案。

## Task 04 — IClock

提供可测试时间抽象。

Core 不依赖 DateTime.Now。

## Task 05 — Location Domain

平台无关：

- latitude
- longitude
- timezone
- display name
- region display name

不引用 Windows Geolocation 类型。

## Task 06 — SolarSchedule Model

保存八阶段 timezone-aware timestamps + fallback metadata。

## Task 07 — ISolarScheduleService

输入：

- local date
- lat/lon
- timezone

输出：

- SolarSchedule
- current phase
- next phase
- next transition

## Task 08 — Phase Resolver

测试：

- before dawn
- exact boundary
- between phases
- exact noon
- sunset
- after night
- cross-midnight

## Task 09 — Normal Solar Timeline

实现：

- Civil Dawn
- Sunrise
- Solar Noon
- Sunset
- Civil Dusk
- Astronomical Dusk
- Morning midpoint
- Afternoon midpoint

严格遵循 SOLAR_ENGINE_SPEC.md。

## Task 10 — High-Latitude Fallback

实现：

- WhiteNight
- TwilightOnly
- PolarDay
- PolarNight
- Defensive

不得发明额外常量。

## Task 11 — Solar Boundary Test Matrix

覆盖：

- summer
- winter
- timezone
- DST
- midnight
- boundary
- white night
- polar day/night
- defensive fallback

## Task 12 — Pause Domain

Paused = freeze final desktop output.

Resume = reconcile current correct state.

不 replay missed phases。

## Task 13 — Local Date Boundary

计算 target timezone 的 local midnight / date rollover。

无 background timer。

## Task 14 — Core Error Conventions

保持最小、明确。

不创建大而全 generic Result framework。

## Task 15 — Phase 1 Integration Test

固定 date/location/timezone/clock：

- generate schedule
- resolve current
- resolve next
- no Windows API
- no network

## Phase 1 Exit

必须：

- deterministic
- tested
- no UI dependency
- no Windows dependency in Core
- all Solar fallback rules resolved
