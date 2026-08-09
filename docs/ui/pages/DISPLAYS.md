# Time Wallpaper — DISPLAYS.md

**Status:** Frozen

页面顶部显示简单真实拓扑矩形：

- 显示器 1
- 显示器 2
- 标主显示器
- 大致反映左右 / 上下排列和宽高比

不截图、不镜像桌面。

## Theme Mode

固定：

- 所有显示器使用相同主题
- 分别配置每台显示器

V0.1 不做 Span。

即使 Shared Theme，每台屏幕仍独立 Render：

- resolution
- aspect
- focal point
- crop
- safe area
- daily content target

## Per Monitor

点击顶部 Monitor Tile，下面只显示当前选中屏设置。

不把 3–4 台完整配置全部纵向铺开。

## Daily Content Target

固定：

- 仅主显示器（默认）
- 所有显示器
- 指定显示器

`PrimaryOnly` 始终跟随当前 Windows Primary Monitor。

## Identity

持久配置使用 `PersistentMonitorId`。

断开不删除配置。

重连恢复原 Theme assignment。

分辨率 / 旋转改变不产生新 identity。

## Refresh

提供次级 `刷新显示器`。

正常情况下 Agent 自动监听 topology。

它是 recovery action，不是日常工作流。
