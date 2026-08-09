# Time Wallpaper — LOCATION.md

**Status:** Frozen

定位方式使用三张 `SettingsCard + RadioButton`：

- 自动定位
- IP 粗略定位
- 手动选择

## 自动定位

首选 Windows Location。

拒绝 / 不可用后：

- 明确说明
- 等待用户决定
- 不静默 IP fallback

系统位置服务关闭时提供：

- 打开 Windows 位置设置
- 使用 IP 粗略定位
- 手动选择

## IP

首次使用弹一次确认。

以后更新无需重复确认。

固定说明：

- 大致位置
- VPN / 代理可能影响结果

不绕过 VPN，不探测真实 IP。

## 手动

- 支持全球城市
- 不做地图
- 不做最近位置
- 不做历史
- 选择后固定，直到用户主动修改

## Solar Timeline

显示完整八阶段时间。

Location 页 Timeline 只读。

Theme Detail Timeline 可点击节点切 Preview。

应复用同一个 SolarTimelineControl。

## Privacy

位置只用于计算当地太阳时间。

不记录移动轨迹。

日志不记录：

- exact coordinates
- IP address

## Low-frequency

定位是低频事件：

- 初次配置
- 用户手动更新
- 合理网络变化
- 时区变化
- 超过 24h 的合理触发

不持续定位。
