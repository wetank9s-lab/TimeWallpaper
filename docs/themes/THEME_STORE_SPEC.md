# Time Wallpaper — THEME_STORE_SPEC.md

**Status:** Frozen

## Tabs

- 已安装
- 在线主题
- 主题来源

## Categories

- 精选
- 自然
- 城市
- 极简
- 超宽屏

## Search

只搜索：

- theme name
- author
- tags

## Theme Card

显示：

- preview
- name
- resolution
- aspect ratio
- phase count
- current / installed / update badge

不显示：

- download count
- rating
- like
- comment
- ranking

## Theme Detail

完整页面。

大图 + Solar Timeline。

官方八阶段用 clickable discrete nodes，不连续拖动。

## Download

下载后不自动应用。

## Update

当前正在使用 Theme 更新成功后：

```text
install new version
→ invalidate old render cache
→ render current phase
→ refresh wallpaper
```

无需再次 Apply。

## Sources

官方源严格版权。

第三方 Source 明确提示“未经官方审核”。

## Integrity

官方在线 Theme：

- HTTPS
- SHA-256
- Theme Validator

## Offline

网络离线时：

- Agent works
- installed Theme works
- local import works
- Studio works

只有在线主题失败。
