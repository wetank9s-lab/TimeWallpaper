# Time Wallpaper — DISPLAYS.md

**Status:** Frozen

## Layout Diagram

顶部简单显示真实 Monitor topology：

- rectangles
- relative position
- resolution
- primary badge

不 capture / mirror desktop。

## Theme Mode

- 所有显示器使用相同主题
- 分别配置每台显示器

V0.1 不 Span。

Shared Theme 仍 per-monitor render。

## Selection

点击 Monitor Tile，下方只显示当前 Monitor 配置。

## Daily Content

- 仅主显示器（默认）
- 所有显示器
- 指定显示器

PrimaryOnly 动态跟随 Windows 当前主屏。

## Identity

持久化 PersistentMonitorId。

断开不删配置。

重连恢复。

Resolution / orientation change 不创建新 identity。

## Refresh

提供次级 `刷新显示器`。

正常由 Agent 自动监听 topology。
