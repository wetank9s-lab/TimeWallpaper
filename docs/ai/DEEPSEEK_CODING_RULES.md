# Time Wallpaper — DEEPSEEK_CODING_RULES.md

**Status:** Frozen

## Role

DeepSeek = implementation assistant, not product designer.

## Source of Truth

1. Current task
2. task-specific spec
3. ARCHITECTURE.md
4. CONFIG_AND_STATE.md
5. UI_DESIGN_SYSTEM.md
6. PRODUCT_SPEC.md
7. V0_1_SCOPE.md
8. NON_GOALS.md

冲突时报告，不猜。

## Never Invent

不得自行增加：

- weather
- analytics
- new navigation
- new settings
- new Theme modes
- animations
- accounts
- cloud sync
- background tasks

## Architecture

禁止：

- Agent → App
- Agent → AI
- Core → WinUI
- Global AppContext
- Service Locator
- circular references

## UI

Views 不写业务逻辑。

ViewModels 不直接：

- Registry
- COM
- Windows Location
- raw JSON
- business paths
- Provider HttpClient

## Renderer

Renderer 是壁纸正文布局唯一真相。

## Design Tokens

不得发明任意 Margin / Radius / Color / Animation。

缺 Token → SPEC GAP。

## Localization

用户可见字符串不硬编码。

zh-CN 主 UI 使用自然中文。

## NuGet

未经批准不加包。

需要新包先报告：

- name
- purpose
- license
- runtime impact

## Network

仅允许：

- IP geolocation
- Theme Store
- Theme download
- GitHub update
- AI generation

其它先报。

## Privacy

禁止日志：

- API Key
- Authorization
- IP
- exact coordinates
- full prompt
- daily content body

## Time

Core 不直接依赖 DateTime.Now。

使用 IClock。

## Monitor

PersistentMonitorId，不保存 Display 1/2 作为 identity。

## Theme

`.twtheme` 只数据，不执行代码。

WDD imported theme 不一定 8 张。

## AI

- optional
- Agent !→ AI
- concurrency 2
- partial success preserved
- regenerate old image preserved until candidate succeeds
- no AI metadata in Theme

## Background Work

`Event-driven > polling`

新增 recurring task 先说明 CPU / wake / network impact。

## Tests

行为改动必须带测试。

不得删除测试只为通过。

## SPEC GAP

如果需要未定义契约：

```text
SPEC GAP:
Missing:
Why needed:
Smallest proposed contract:
Affected projects:
Persistent-data impact:
Background/network impact:
```

未经批准不实现。

## Navigation

固定：

- 首页
- 主题
- 创作
- 每日内容
- 时间与位置
- 显示器
- 设置

## Theme Studio

固定：

- top toolbar
- canvas
- 312px inspector
- 120px phase strip

## Completion

确认：

- build
- tests
- no unapproved package
- no hardcoded UI text
- no architecture violation
- no hidden polling
- no privacy violation
- no NON_GOALS violation

## Prime Directive

> Implement less, follow the specification, report the gap.
