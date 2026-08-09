# Time Wallpaper / 时辰壁纸 — V0.1 Documentation Pack

本目录整理了当前已经冻结的 V0.1 产品、架构、UI、AI 与发布规范。

## 产品定位

时辰壁纸是一款面向 Windows 10 22H2 / Windows 11 的轻量动态壁纸软件。

核心体验：

> 根据用户所在地点、当地太阳时间、日期与文化时间，让同一个桌面场景在一天中自然变化。

核心原则：

- 壁纸永远是第一主角
- Agent 空闲 CPU 接近 0
- 不做视频壁纸、不做持续 GPU 渲染
- 定位仅用于计算当地太阳时间
- UI 面向中国用户，主界面不使用纯英文菜单或按钮
- WinUI 3 + Windows App SDK
- Store = MSIX Bundle
- GitHub = x64 / ARM64 Self-contained EXE Installer

## 文档目录

```text
docs/
├── product/
│   ├── PRODUCT_SPEC.md
│   ├── V0_1_SCOPE.md
│   └── NON_GOALS.md
│
├── architecture/
│   ├── ARCHITECTURE.md
│   ├── IMPLEMENTATION_ORDER.md
│   ├── CONFIG_AND_STATE.md
│   └── DISTRIBUTION.md
│
├── ui/
│   └── pages/
│       ├── ONBOARDING.md
│       ├── HOME.md
│       ├── THEMES.md
│       ├── DAILY_CONTENT.md
│       ├── LOCATION.md
│       ├── DISPLAYS.md
│       ├── SETTINGS.md
│       ├── STUDIO_FLOW.md
│       ├── THEME_STUDIO.md
│       └── AI_DYNAMIC.md
│
└── ai/
    └── DEEPSEEK_CODING_RULES.md
```

## 推荐开发顺序

1. Repository / Architecture
2. Core + Solar Engine
3. Theme Engine
4. Windows Wallpaper Platform
5. Renderer + Content
6. Agent
7. WinUI Application
8. Theme Studio + Store + AI
9. Distribution / Release Hardening
