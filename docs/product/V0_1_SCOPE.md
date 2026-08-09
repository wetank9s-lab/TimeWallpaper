# Time Wallpaper — V0_1_SCOPE.md

**Status:** Frozen

## 1. V0.1 必须交付

### Core

- Solar Timeline
- 8 official phases
- Polar-day/night fallback
- Timezone handling
- Daily content selection
- Solar terms
- Holidays
- Settings / State model

### Windows Platform

- IDesktopWallpaper integration
- Multi-monitor enumeration
- Primary monitor detection
- Persistent monitor identity
- Sleep / Resume
- Unlock
- Display topology changes
- Windows Location
- Network state triggers
- Startup registration
- `.twtheme` activation

### Agent

- Tray
- Auto switching
- Pause / Resume
- Refresh wallpaper
- Next transition scheduling
- Wallpaper state recovery
- Startup execution

### Theme Engine

- `.twtheme` ZIP
- manifest
- Theme Validator
- themeId + version
- 8-phase official standard
- Focal Point
- Safe Area
- Preview image
- Install / Remove / Update
- WDD Theme Importer
- SHA-256 Store validation

### Renderer

- Per-monitor crop
- Focal Point
- Safe Area mapping
- Poetry / English rendering
- Solar term / holiday rendering
- Auto text color
- Opacity
- Shadow
- Render Cache
- Preview rendering

### Built-in Content

- Curated Desktop Poetry
- Elegant English Words
- Solar Terms
- Holidays

### Built-in Themes

- 山湖
- 建筑
- 天空

## 2. UI 必须完成

- Onboarding
- Home
- Themes
- Theme Detail
- Daily Content
- Time & Location
- Displays
- Settings
- Studio Home
- Theme Studio
- AI Dynamic
- AI Service Settings

## 3. AI 必须完成

- Reference image
- Target ratio
- Optional additional requirements
- 8 phases
- Max concurrency = 2
- Phase-level state
- Retry
- Regenerate candidate
- Manual replace
- Partial success
- Recovery Draft
- Continue to Theme Studio

## 4. 多显示器必须完成

- Monitor topology diagram
- Shared theme
- Per-monitor theme
- Per-monitor Render Profile
- Primary-only daily content
- All monitors daily content
- Selected monitors daily content
- Persistent monitor assignment
- Manual refresh displays

## 5. 位置必须完成

- Windows Location
- Explicit IP consent
- Manual global city search
- Cached location
- Low-frequency smart refresh
- Solar Timeline
- Open Windows Location Settings

## 6. 设置必须完成

- Startup
- Background behavior explanation
- System / Light / Dark
- App update strategy
- Theme update strategy
- Cache size
- Clear cache
- Logs
- AI service entry
- About
- Licenses
- Privacy
- GitHub

## 7. 发布必须完成

Microsoft Store：

- MSIX Bundle
- x64 + ARM64
- Framework-dependent

GitHub：

- EXE Installer x64
- EXE Installer ARM64
- Self-contained

## 8. 测试最低覆盖

- Solar schedule
- Phase resolution
- Polar fallback
- Theme validation
- `.twtheme` package safety
- WDD import
- Safe Area validation
- Focal Point validation
- Daily content stability
- Monitor assignment
- Cache keys
- Settings migration/versioning

## 9. 人工验收场景

- 首次安装
- 离线首次启动
- Windows 定位允许 / 拒绝
- IP fallback
- 手动位置
- 单显示器 / 双显示器
- 16:9 + 21:9
- 更换主显示器
- 拔插外接显示器
- Sleep / Resume
- Lock / Unlock
- Explorer restart
- Timezone change
- Theme install / update / delete
- WDD import
- Daily content on/off
- 节气日 / 节日日
- App UI close
- Agent tray exit
- AI full success
- AI partial failure
- AI page close
- Draft recovery

## 10. Definition of Done

V0.1 必须同时满足：

- Core reliable
- Agent reliable
- Multi-monitor reliable
- Renderer reliable
- Onboarding understandable
- Theme package safe
- Privacy rules satisfied
- No hidden continuous background work
