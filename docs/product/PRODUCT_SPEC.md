# Time Wallpaper — PRODUCT_SPEC.md

**Status:** Frozen  
**Version:** V0.1  
**Product:** 时辰壁纸 / Time Wallpaper

## 1. 产品定义

时辰壁纸是一款面向 Windows 10 / 11 的轻量动态壁纸软件。

核心体验：

> 根据用户所在地点、当地太阳时间、日期与文化时间，让同一个桌面场景在一天中自然变化。

重点不是视频动画、实时 3D 或持续 GPU 渲染，而是：

- 时间感
- 地点感
- 晨昏光影
- 每日一句
- 节气与节日
- 安静运行
- 长期可靠

## 2. 产品原则

### 壁纸永远是第一主角

每日内容、节气、节日只是辅助信息。

禁止把桌面做成：

- 日历
- 天气面板
- 学习软件
- 新闻 Feed
- Dashboard
- 海报

### 自动运行

用户不需要每天：

- 打开 App
- 手动切壁纸
- 手动刷新太阳时间
- 手动处理阶段
- 持续更新位置

Agent 自动维护正确状态。

### 轻量

目标：

- Agent 空闲 CPU ≈ 0%
- 后台内存目标约 20–40 MB
- 无持续 GPU Rendering
- 无视频 Decoder
- 无 WebView 常驻
- 无 Electron

安装包大小不是第一优化指标。

## 3. 平台

支持：

- Windows 10 22H2
- Windows 11
- x64
- ARM64

不支持：

- x86
- Windows 7 / 8
- Portable V0.1

UI：

- WinUI 3
- Windows App SDK
- Mica
- Windows System Accent
- 系统 / 浅色 / 深色

## 4. 八阶段 Solar Timeline

固定阶段：

1. 黎明
2. 日出
3. 上午
4. 正午
5. 下午
6. 日落
7. 暮色
8. 深夜

阶段基于真实太阳事件和高纬 fallback，而不是固定 3/6/9/12 点。

V0.1 只做离散切换，不做 Cross Fade 或连续中间帧。

## 5. 定位

三级模式：

1. Windows 定位
2. IP 粗略定位
3. 手动位置

隐私规则：

- Windows 定位失败后不静默调用 IP
- IP 第一次使用必须显式确认
- 手动位置优先级最高
- 不做地图
- 不做位置历史
- 不持续 GPS
- 太阳时间本机计算

## 6. 每日内容

固定模式：

- 中英交替（默认）
- 仅诗词
- 仅英语
- 关闭每日内容

诗词：

- Curated Desktop Poetry
- 诗句 + 作者 + 作品名
- 人工精选
- 当天保持稳定
- 不提供“换一句”

英语：

- Elegant Everyday English
- 单词 + 中文释义
- 不显示音标
- 不显示英文解释
- 不做背单词系统

## 7. 节气与节日

支持：

- 二十四节气
- 中国传统节日
- 少量国际节日

只增加克制文字，不改变壁纸视觉。

## 8. 多显示器

主题模式：

- 所有显示器使用相同主题
- 分别配置每台显示器

每台屏幕独立：

- Render Profile
- Focal Point
- Crop
- Safe Area
- Daily Content Target

每日内容默认仅主显示器。

## 9. Theme

新格式：

`*.twtheme`

本质：ZIP 数据包。

只允许图片与数据，不允许可执行代码。

官方标准为八阶段，但 WDD Importer 必须兼容 2 / 4 / 16 / 24 等旧主题。

## 10. Theme Library

中文版使用：

- 主题
- 在线主题
- 主题来源

分类：

- 精选
- 自然
- 城市
- 极简
- 超宽屏

不做评分、评论、点赞、下载榜。

## 11. 创作 / Theme Studio

两条入口：

- 从图片创建
- AI 动态化

统一进入 `ThemeDraft` 和同一个 Theme Studio。

正式保存 / 导出要求 8/8 阶段完整。

## 12. AI

V0.1 主要能力：

```text
一张参考图片
→ 八个时间阶段
→ ThemeDraft
→ Theme Studio
```

BYOK。

最大生成并发：2。

最终 Theme 不记录 Provider / Model / Prompt / API Key / AI Metadata。

Agent 不引用 AI。

## 13. UI

默认窗口：1180 × 760  
最小窗口：920 × 620

左侧导航：

- 首页
- 主题
- 创作
- 每日内容
- 时间与位置
- 显示器
- 设置

中文 UI 不使用纯英文主菜单或按钮。

## 14. 首次启动

固定三屏：

- 1 / 3 产品介绍
- 2 / 3 位置
- 3 / 3 每日内容

第一屏使用用户提供的静态“晨 → 昼 → 夜”同场景组合视觉。

第三屏默认中英交替。

完成后直接应用内置“山湖”。

## 15. 内置主题

- 山湖
- 建筑
- 天空

全部完整八阶段。

## 16. Agent

负责：

- Solar Schedule
- Theme State
- Monitor State
- Render Cache
- Wallpaper Apply
- Tray
- Pause
- Sleep / Resume
- Display Events
- Recovery

Tray：

- 打开时辰壁纸
- 暂停自动切换
- 刷新当前壁纸
- 退出

## 17. 隐私

V0.1：

- No Telemetry
- No Analytics
- No third-party crash reporting

日志保留 7 天。

日志禁止记录：

- API Key
- Authorization Header
- IP
- 精确坐标
- Prompt
- 每日内容正文

## 18. 发布

Store：

- MSIX Bundle
- x64 + ARM64
- Framework-dependent
- Store 管理 App Binary 更新

GitHub：

- EXE Installer x64
- EXE Installer ARM64
- Self-contained
- 只检查并提示更新
