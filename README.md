# Time Wallpaper / 时辰壁纸 — V0.1 Documentation Pack

**Status:** Latest consolidated documentation  
**Target:** GitHub repository docs baseline  
**Product:** 时辰壁纸 / Time Wallpaper

## Product Summary

时辰壁纸是一款面向 Windows 10 22H2 / Windows 11 的轻量动态壁纸软件。

核心体验：

> 根据用户所在地点、当地太阳时间、日期与文化时间，让同一个桌面场景在一天中自然变化。

核心原则：

- 壁纸永远是第一主角
- 同一场景八阶段 Solar Timeline
- Agent 空闲 CPU 接近 0
- UI 关闭后 Agent 继续运行
- 不做视频壁纸、不做持续 GPU 渲染
- Windows 定位优先，IP fallback 必须显式同意
- 每日内容本地精选，不使用 AI 每日生成文本
- WinUI 3 + Windows App SDK
- 中文 UI 优先
- Store = MSIX Bundle
- GitHub = x64 / ARM64 Self-contained EXE Installer
- No Telemetry
- No third-party crash reporting

## Documentation Tree

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
│   ├── SOLAR_ENGINE_SPEC.md
│   └── DISTRIBUTION.md
│
├── themes/
│   ├── THEME_SPEC.md
│   └── THEME_STORE_SPEC.md
│
├── ui/
│   ├── UI_DESIGN_SYSTEM.md
│   ├── UI_NAVIGATION.md
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
    ├── DEEPSEEK_CODING_RULES.md
    ├── PROMPT_TEMPLATES.md
    └── PHASE_0_1_DEEPSEEK_TASKS.md
```

## Recommended Development Order

1. Repository / Architecture
2. Core + Solar Engine
3. Theme Engine
4. Windows Wallpaper Platform
5. Renderer + Content
6. Agent
7. WinUI Application
8. Theme Studio
9. Theme Store
10. AI Dynamic
11. Distribution / Release Hardening

## Important

This documentation is intentionally strict.

When implementing with DeepSeek or another coding model:

- do not invent missing product behavior;
- do not add NuGet packages without approval;
- do not merge App and Agent;
- do not introduce hidden polling;
- do not add telemetry;
- report `SPEC GAP` when the frozen documents do not define a required behavior.
