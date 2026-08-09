# Time Wallpaper — DAILY_CONTENT.md

**Status:** Frozen

页面职责：

- 内容模式
- 文字全局外观
- 节气 / 节日开关
- 真实 Renderer Preview

不负责 Safe Area / 位置。

## Preview

- 顶部真实壁纸预览
- 默认 16:9
- MaxHeight ≈ 300
- 超宽按真实比例
- Renderer 是唯一真相

提供：

- 预览诗词
- 预览英语

只影响设置页预览，不改变当天真实内容。

## 内容模式

- 中英交替（默认）
- 仅诗词
- 仅英语
- 关闭每日内容

关闭每日内容后，节气 / 节日仍可继续显示。

## 节气与节日

默认全部开启：

- 二十四节气
- 中国传统节日
- 国际节日

## 外观

仅：

- 字体
- 字号
- 文字颜色：自动 / 浅色 / 深色 / 自定义
- 透明度
- 阴影
- 恢复默认文字样式

允许选择 Windows 已安装字体。

不捆绑额外字体。

字体被卸载后 fallback 到系统默认。

## 实时预览

App Preview 实时更新。

实际 Windows 桌面刷新需要 debounce，不能 slider 每一帧都重新编码和 SetWallpaper。

## Reset

只重置：

- 字体
- 字号
- 颜色
- 透明度
- 阴影

不重置模式 / 节日开关 / Theme / Safe Area。
