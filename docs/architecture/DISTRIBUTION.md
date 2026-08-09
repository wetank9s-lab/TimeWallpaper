# Time Wallpaper — DISTRIBUTION.md

**Status:** Frozen

## Microsoft Store

- MSIX Bundle
- x64 + ARM64
- Framework-dependent
- Store-managed app update

## GitHub

- TimeWallpaper-Setup-x64.exe
- TimeWallpaper-Setup-arm64.exe
- Self-contained
- app checks + notifies only

不做：

- x86
- Portable
- giant universal installer
- duplicate Store/GitHub app codebases

## DistributionChannel

- MicrosoftStore
- GitHub
- Development

隔离渠道差异：

- IDistributionEnvironment
- IStartupRegistration
- IAppUpdateService
- IThemeFileAssociation
- IAppPaths

## Startup

Store：StartupTask → Agent  
GitHub：Win32 user startup → Agent

不开 WinUI 主窗口。

## .twtheme

Store：Manifest association  
GitHub：Installer ProgID

用户体验统一。

## Settings

Store：

- 软件更新由 Microsoft Store 管理

GitHub：

- 自动检查软件更新
- 检查更新

Theme Update 两种渠道都由 App 自己管理。
