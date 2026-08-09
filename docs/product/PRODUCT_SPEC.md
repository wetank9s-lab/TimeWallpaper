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

### 2.1 壁纸永远是第一主角

每日内容、节气、节日只是辅助信息。

禁止把桌面变成：

- 日历
- 天气面板
- 学习软件
- 新闻 Feed
- Dashboard
- 海报

### 2.2 自动运行

用户不应每天手工：

- 切壁纸
- 刷新时间
- 更新位置
- 处理阶段

Agent 自动维护正确状态。

### 2.3 轻量定义

目标：

- Agent 空闲 CPU ≈ 0%
- 后台内存目标约 20–40 MB
- 无持续 GPU Rendering
- 无视频 Decoder
- 无 WebView 常驻
- 无 Electron

安装包大小不是第一优化指标。

## 3. 平台与架构

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

Agent：

- 独立后台进程
- 不引用 WinUI
- 不引用 AI

## 4. 八阶段 Solar Timeline

官方标准：

1. 黎明
2. 日出
3. 上午
4. 正午
5. 下午
6. 日落
7. 暮色
8. 深夜

阶段基于日期、经纬度、时区与太阳事件计算，不使用固定 03:00 / 06:00 等机械时间。

极昼 / 极夜自动 fallback。

V0.1 只做离散切换，不做 Cross Fade、连续插值或视频过渡。

## 5. 定位

三级模式：

1. Windows 定位
2. IP 粗略定位
3. 手动位置

关键隐私规则：

- Windows 定位失败后不得静默调用 IP
- IP 第一次使用必须显式确认
- 手动位置优先级最高
- 不做地图
- 不做位置历史
- 不做持续 GPS
- 太阳时间在本机计算

## 6. 每日内容

固定四种模式：

- 中英交替（默认）
- 仅诗词
- 仅英语
- 关闭每日内容

诗词：

- 人工精选 Curated Desktop Poetry
- 诗句 + 作者 + 作品名
- 适合桌面展示
- 不做“换一句”

英语：

- Elegant Everyday English
- 单词 + 中文释义
- 不显示音标
- 不显示英文解释
- 不做 CET / IELTS / GRE 学习系统

## 7. 节气与节日

支持：

- 二十四节气
- 中国传统节日
- 少量国际节日

只增加轻量文字，不改变壁纸视觉，不加灯笼、雪花、红色滤镜等。

## 8. 多显示器

主题模式：

- 所有显示器使用相同主题
- 分别配置每台显示器

即使主题相同，每个显示器也独立执行：

- Focal Point
- Crop
- Safe Area
- Daily Content Target
- Renderer

每日内容默认只显示主显示器，也支持所有显示器 / 指定显示器。

## 9. 主题格式

新格式：

`*.twtheme`

本质：

ZIP 数据包。

典型结构：

```text
Theme.twtheme
├── manifest.json
├── preview.webp
└── images/
    ├── dawn.webp
    ├── sunrise.webp
    ├── morning.webp
    ├── noon.webp
    ├── afternoon.webp
    ├── sunset.webp
    ├── dusk.webp
    └── night.webp
```

Theme Package 只允许数据和图片，不执行代码。

## 10. WDD 兼容

仓库保留 WinDynamicDesktop 历史与许可证血统：

```text
legacy/WinDynamicDesktop/
```

新 Time Wallpaper 架构单独建立。

兼容：

- WDD Theme Import
- 有价值的 Wallpaper / COM 实现
- Solar 经验
- Refresh / Theme Switching 等常用命令

不做完整 WDD 配置迁移工具。

## 11. 在线主题

中文版使用“在线主题 / 主题库”。

分类：

- 精选
- 自然
- 城市
- 极简
- 超宽屏

支持搜索：

- 名称
- 作者
- 标签

不做：

- 评分
- 点赞
- 评论
- 下载榜
- 社交 Feed

官方源不收未经授权的动漫、影视、游戏素材。

## 12. Theme Studio

中文版入口：**创作**

支持：

- 从图片创建
- AI 动态化

二者统一进入同一个 `ThemeDraft` / Theme Studio。

Theme Studio 支持：

- 1–8 张图片进入 Draft
- 正式保存要求 8/8
- 阶段拖拽 / 交换 / 移动
- Focal Point
- Safe Area
- 实时文字示例
- Draft Recovery
- App 内预览
- 保存
- 导出 `.twtheme`
- 创建副本

## 13. AI 动态化

核心：

```text
一张参考图片
→ 八个时间阶段
→ ThemeDraft
→ Theme Studio
```

BYOK。

不提供官方收费 AI 服务。

目标比例：

- 16:9
- 16:10
- 21:9
- 32:9
- 跟随原图

最大并发生成任务：2。

AI Theme 不记录：

- Provider
- Model
- Prompt
- API Key
- Generation Metadata

Agent 不引用 AI。

## 14. UI

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

中文版正式 UI 不使用纯英文菜单或按钮。

## 15. 首次启动

固定三屏：

- 1 / 3 产品介绍（静态“晨 → 昼 → 夜”组合视觉）
- 2 / 3 位置
- 3 / 3 每日内容

第三屏默认“中英交替”。

完成后直接应用默认“山湖”主题并进入首页。

## 16. 默认主题

安装包内置：

- 山湖
- 建筑
- 天空

全部为完整八阶段主题。

## 17. Agent

职责：

- Solar Schedule
- Theme State
- Monitor State
- Renderer Cache
- Wallpaper Apply
- Tray
- Pause
- Sleep / Resume
- Display Events
- Recovery

Tray 菜单：

- 打开时辰壁纸
- 暂停自动切换
- 刷新当前壁纸
- 退出

## 18. 隐私

V0.1：

- No Telemetry
- No Analytics
- No third-party crash reporting

日志仅本地，保留 7 天。

日志禁止记录：

- API Key
- Authorization Header
- IP 地址
- 精确坐标
- Prompt
- 诗词正文
- 英语正文

## 19. 发布

Microsoft Store：

- MSIX Bundle
- x64 + ARM64
- Framework-dependent
- Store 管理 App 更新

GitHub：

- EXE Installer x64
- EXE Installer ARM64
- Self-contained
- 只检查并提示更新，不静默安装

## 20. V0.1 成功标准

优先级：

1. 唤醒后壁纸正确
2. 多显示器可靠
3. Solar Timeline 正确
4. UI 关闭后 Agent 继续正常
5. CPU 长期接近 0
6. 首次使用易理解
7. Theme 导入 / 更新可靠
8. Renderer 所见即所得
9. 不打扰用户
10. 没有不必要联网
