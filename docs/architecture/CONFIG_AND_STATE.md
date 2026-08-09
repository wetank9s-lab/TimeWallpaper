# Time Wallpaper — CONFIG_AND_STATE.md

**Status:** Frozen

## Three Layers

```text
Settings = user intent
State    = runtime-derived state
Secrets  = sensitive credentials
```

```text
Config/
├── settings.json
└── state.json

Secret Store
└── AI API Key
```

## settings.json

保存：

- App theme
- Startup
- Theme assignments
- Daily Content settings
- Text appearance
- Location mode
- Manual location
- Display prefs
- Theme update prefs
- GitHub app update pref
- AI provider non-secret config

## state.json

保存：

- OnboardingCompleted
- BackgroundCloseNoticeShown
- Daily local date
- Today's content ID
- Cached automatic location
- LastLocationCheck
- IP consent
- Solar schedule cache
- CurrentPhase
- Pause state
- Last reconciliation

## Secrets

API Key 不写 JSON / logs / Theme / Draft。

## schemaVersion

Settings 和 State 都用独立整数 schemaVersion。

## Manual vs Automatic Location

Manual location = Settings  
Automatic detected location = State

## Monitor Assignment

只保存 PersistentMonitorId。

PrimaryOnly 不绑定物理 ID。

## Daily Content

保存 ID，不必保存完整正文。

不会因 App / Agent restart 重抽。

## Defaults

- AppTheme = System
- StartupEnabled = true
- DailyContentMode = Alternating
- SolarTerms = true
- TraditionalHolidays = true
- InternationalHolidays = true
- TextColor = Auto
- Shadow = true
- ThemeMode = Shared
- SharedTheme = Lake
- DailyContentDisplay = PrimaryOnly
- AutoCheckThemeUpdates = true
- GitHub AutoCheckAppUpdates = true

Defaults 必须集中定义。

## Atomic Writes

```text
Serialize
→ temp
→ flush
→ atomic replace
```

## Corruption

State corrupt → sanitize log + rebuild  
Settings corrupt → preserve bad copy + recover/default + notify

## Migration

- ISettingsMigration
- IStateMigration

按 schema 逐级迁移。

## Cross Process

App 写 Settings。  
Agent 写 runtime State。  
App 写 Settings 后 IPC 通知 Agent Reload。

不 polling 文件。

## WDD

只读 `WddSettingsReader`。

不自动迁移、不修改旧配置。
