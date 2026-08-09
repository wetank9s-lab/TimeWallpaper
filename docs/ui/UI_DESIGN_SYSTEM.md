# Time Wallpaper — UI_DESIGN_SYSTEM.md

**Status:** Frozen

## Window

- Default: 1180 × 760
- Minimum: 920 × 620
- Backdrop: Mica

## Accent

使用 Windows System Accent。

不创建固定品牌蓝 / 紫色。

## App Theme

- 跟随系统（默认）
- 浅色
- 深色

壁纸亮暗不得自动改变 App Theme。

## Navigation

NavigationView-style Windows 11 shell。

导航宽度：

`TW.Nav.OpenWidth = 240`

## Spacing Tokens

```text
TW.Space.XS  = 4
TW.Space.S   = 8
TW.Space.M   = 12
TW.Space.L   = 16
TW.Space.XL  = 24
TW.Space.XXL = 32
```

`TW.Page.Padding = 24`

Settings pages max width ≈ 1000  
Visual pages max width ≈ 1280

## Radius

- Standard Card: 8px
- Hero: 12px
- Image Preview: 8px

## Typography

App UI 使用 Windows / Fluent system typography。

壁纸正文属于 Renderer，不与 App UI typography 混用。

## Motion

允许：

- Navigation Transition
- 轻微 Fade
- ProgressRing
- 原生控件 state animation

禁止：

- bounce
- parallax
- spring
- card scale hover
- Ken Burns
- 大面积 Blur animation

## Chinese UI

主导航 / 菜单 / 按钮使用自然中文。

英文只用于：

- code
- internal IDs
- necessary technical abbreviations
- theme author content/title when appropriate

## Resource Rule

用户可见字符串不得硬编码在 XAML / C#。

使用 zh-CN resources。

## Studio Tokens

- `TW.Studio.InspectorWidth = 312`
- `TW.Studio.PhaseStripHeight = 120`
