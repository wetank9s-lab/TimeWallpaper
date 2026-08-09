# Time Wallpaper — LOCATION.md

**Status:** Frozen

定位方式：

- 自动定位
- IP 粗略定位
- 手动选择

使用 SettingsCard + RadioButton。

## Auto

Windows Location 优先。

失败 / 拒绝：

- 明确提示
- 不静默 IP
- 提供 IP / Manual

系统定位关闭时提供：

`打开 Windows 位置设置`

## IP

第一次使用弹一次确认。

之后无需反复确认。

固定提示 VPN / 代理可能影响结果。

## Manual

支持全球城市。

不做：

- 地图
- 最近位置
- 位置历史

Manual 模式下 Agent 不自动 relocation。

## Solar Timeline

显示全部八阶段真实时间。

Location 页为 Read-only。

复用 shared SolarTimelineControl。

## Privacy

不记录：

- exact coordinates in logs
- IP
- location history
