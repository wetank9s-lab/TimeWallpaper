# Time Wallpaper — DISTRIBUTION.md

**Status:** Frozen

## 1. 双渠道

### Microsoft Store

- MSIX Bundle
- x64 + ARM64
- Framework-dependent
- Microsoft Store 管理 App 更新

### GitHub

- TimeWallpaper-Setup-x64.exe
- TimeWallpaper-Setup-arm64.exe
- Self-contained
- App 只检查更新并提示，不静默安装

## 2. 不做

- x86
- Portable
- Universal giant installer
- 两套 App 代码

## 3. DistributionChannel

```text
MicrosoftStore
GitHub
Development
```

通过：

- IDistributionEnvironment
- IStartupRegistration
- IAppUpdateService
- IThemeFileAssociation
- IAppPaths

隔离渠道差异。

## 4. Startup

Store：

- MSIX StartupTask
- 启动 Agent，不打开 WinUI 主窗口

GitHub：

- per-user Win32 startup registration
- 启动 Agent

## 5. `.twtheme`

Store：Manifest file association  
GitHub：Installer ProgID association

用户体验统一：

```text
双击 .twtheme
→ 时辰壁纸
→ 安装确认
→ Validate
→ Install
→ Theme Detail
```

## 6. Settings Update Section

Store：

```text
软件更新
由 Microsoft Store 管理
当前版本
[在 Microsoft Store 中查看]
```

GitHub：

```text
软件更新
自动检查软件更新 [开]
当前版本
[检查更新]
```

Theme Update 在两种渠道都由时辰壁纸自己管理。

## 7. User Data

Program Files / Package 与用户数据完全分离。

所有路径通过 `IAppPaths`。

更新 / 卸载不得误删用户主题、配置或草稿。
