# Time Wallpaper — CONFIG_AND_STATE.md

**Status:** Frozen

## 1. 三层分离

```text
Settings = 用户意图
State    = 运行状态
Secrets  = 敏感凭据
```

文件：

```text
Config/
├── settings.json
└── state.json

Secret Store
└── AI API Key
```

## 2. settings.json

保存：

- App theme
- Startup preference
- Theme assignments
- Daily content mode
- Text appearance
- Location mode
- Manual location
- Display preferences
- Theme update preference
- GitHub app update preference
- AI provider non-secret config

不保存 API Key。

## 3. state.json

保存：

- OnboardingCompleted
- BackgroundCloseNoticeShown
- Daily local date
- Today's content ID
- Cached location
- Last location check
- IP consent
- Solar Schedule cache
- Current phase
- Pause state
- Last reconciliation

## 4. Schema Version

两个文件都含：

```json
{
  "schemaVersion": 1
}
```

SchemaVersion 与 AppVersion 分开。

## 5. Manual vs Automatic Location

Manual location 属于 Settings。

Automatic detected location 属于 State。

IP first-use consent 属于 State。

## 6. Monitor Assignment

只持久化 `PersistentMonitorId`。

不使用 `显示器 1 / 显示器 2` 作为持久 ID。

`PrimaryOnly` 不绑定物理显示器，运行时动态解析当前 Windows 主屏。

## 7. Today's Daily Content

State 建议保存：

```text
localDate
contentType
contentId
```

不需要存完整正文。

不会因 App restart / Agent restart / monitor reconnect 而重新随机。

## 8. Defaults

集中定义：

- AppTheme = System
- StartupEnabled = true
- DailyContentMode = Alternating
- SolarTermsEnabled = true
- TraditionalHolidaysEnabled = true
- InternationalHolidaysEnabled = true
- TextColorMode = Auto
- ShadowEnabled = true
- ThemeMode = Shared
- SharedThemeId = built-in Lake
- DailyContentDisplayMode = PrimaryOnly
- AutoCheckThemeUpdates = true
- GitHub AutoCheckAppUpdates = true

## 9. Atomic Writes

建议：

```text
Serialize
→ temp file
→ flush
→ atomic replace
```

不要直接 truncate 原配置。

## 10. Corruption Recovery

`state.json` 损坏：

- sanitized log
- 重建安全 State
- 继续运行

`settings.json` 损坏：

- 先保存损坏副本
- 尝试恢复/默认
- 提示用户

## 11. Migration

使用：

- ISettingsMigration
- IStateMigration

按 schema 逐级迁移。

新版本 schema > 当前支持版本时，不得盲目重写。

## 12. Cross-process

推荐：

- App 写用户 Settings
- Agent 写 runtime State
- App 写 Settings 后通过 IPC 通知 Agent Reload

不要每几秒轮询文件。

## 13. WDD settings.json

只读 `WddSettingsReader`。

不自动扫描、不自动迁移、不修改原 WDD 配置。
