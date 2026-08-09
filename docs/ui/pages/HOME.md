# Time Wallpaper — HOME.md

**Status:** Frozen

结构：

```text
[Pause InfoBar conditional]

[Wallpaper Hero]

                       [更换主题] [⋯]

[位置] [日落] [下一阶段]

[节气 / 节日 Info Row conditional]
```

## Hero

- 当前实际 Renderer 输出缩略预览
- 不重新用 XAML 模拟诗词
- 默认 16:9
- MaxHeight ≈ 400
- 超宽主题按真实比例
- 左下角只显示：`主题名 · 当前阶段`
- 允许局部轻 Gradient 只保护这行 App Chrome
- 每日内容仍使用真实 Renderer

## 信息卡固定

- 位置
- 日落
- 下一阶段

节日 / 节气不是第四等宽 Card，而是独立轻量行。

## Actions

Hero 下方右侧：

- 更换主题
- ⋯

More：

- 刷新当前壁纸
- 暂停自动切换
- 打开壁纸文件夹

## Pause

InfoBar：

`自动切换已暂停 [恢复]`

不在 Hero 中心放大暂停图标。

## 禁止

- 天气
- 数字时钟
- Theme Update
- CPU/RAM
- 通知中心式内容
