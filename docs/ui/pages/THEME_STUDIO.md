# Time Wallpaper — THEME_STUDIO.md

**Status:** Frozen

固定布局：

```text
Top Toolbar
Canvas
312px Inspector
120px Phase Strip
```

不做 IDE Docking。

## Toolbar

固定：

- 预览
- 保存
- ⋯

低频操作放 More：

- 导出主题
- 创建副本
- 打开主题文件夹
- 放弃草稿（视 ownership）

## Canvas Modes

互斥三种：

- 查看
- 视觉焦点
- 文字安全区域

不同时编辑 Focal Point + Safe Area。

## Focal Point

- Theme-level
- normalized x/y
- 拖动 marker

## Safe Area

- Theme-level
- normalized x/y/width/height
- drag + resize
- min width ≈ 0.10
- min height ≈ 0.08
- 不允许出画布
- 编辑时显示真实示例文字
- 示例文字复用 Renderer

快捷预设：

- 左上
- 右上
- 左下
- 右下
- 自定义

## Inspector

固定三个 SettingsExpander：

- 主题
- 画面
- 文字区域

不使用顶部 Tabs。

## Phase Strip

八阶段固定：

- 黎明
- 日出
- 上午
- 正午
- 下午
- 日落
- 暮色
- 深夜

支持 Drag & Drop：

- occupied → occupied = swap
- occupied → empty = move

不复制。

## Preview

App 内预览，不调用 Wallpaper API。

## Save

不完整 Draft 点击保存时必须提示缺失阶段。

正式 Theme 必须通过 Validator。
