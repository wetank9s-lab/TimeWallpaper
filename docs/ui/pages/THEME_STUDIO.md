# Time Wallpaper — THEME_STUDIO.md

**Status:** Frozen

固定布局：

```text
Top Toolbar
Canvas
312px Inspector
120px Phase Strip
```

## Toolbar

- 预览
- 保存
- ⋯

低频动作放 More。

## Canvas Modes

互斥：

- 查看
- 视觉焦点
- 文字安全区域

## Focal Point

- theme-level
- normalized x/y

## Safe Area

- theme-level
- normalized x/y/width/height
- drag + resize
- min width ≈ 0.10
- min height ≈ 0.08
- within bounds
- edit mode displays real Renderer sample text

Presets：

- 左上
- 右上
- 左下
- 右下
- 自定义

## Inspector

SettingsExpander：

- 主题
- 画面
- 文字区域

不使用顶层 tabs。

## Phase Strip

八阶段始终可见。

Drag:

- occupied → occupied = swap
- occupied → empty = move

不复制。

## Preview

App-only。

不调用 Wallpaper API。

## Save

不完整 Draft 明确显示缺失阶段。

正式 Theme 必须 Validator pass。
