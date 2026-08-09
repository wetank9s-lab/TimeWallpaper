# Time Wallpaper — HOME.md

**Status:** Frozen

结构：

```text
Pause InfoBar (conditional)

Wallpaper Hero

                    更换主题  ⋯

位置 | 日落 | 下一阶段

DateInfoRow (conditional)
```

## Hero

- 显示实际 Renderer 输出
- 默认 16:9
- MaxHeight ≈ 400
- ultrawide 按真实比例
- Safe Area / text appearance 真实所见即所得
- 左下角只显示 `Theme · Phase`
- 只允许该 App Chrome 附近轻微局部 Gradient

## Cards

固定三个：

- 位置
- 日落
- 下一阶段

节气 / 节日为独立轻量行。

## Pause

`自动切换已暂停 [恢复]`

不在 Hero 中央放大图标。

## 禁止

- 天气
- 数字时钟
- Theme update
- CPU/RAM
- notification center
