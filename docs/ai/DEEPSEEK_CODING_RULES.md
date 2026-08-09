# Time Wallpaper — DEEPSEEK_CODING_RULES.md

**Status:** Frozen

## 1. 角色

DeepSeek 是实现助手，不是产品设计者或架构拥有者。

目标：

> 严格实现给定规格。

不是：

- 重设计应用
- 顺手加功能
- 改架构
- 自行选择新技术栈

## 2. Source of Truth

优先顺序：

1. 当前任务
2. 当前 Page / Component Spec
3. ARCHITECTURE.md
4. CONFIG_AND_STATE.md
5. UI Design System
6. PRODUCT_SPEC.md
7. V0_1_SCOPE.md
8. NON_GOALS.md

冲突时：不要猜，报告冲突。

## 3. 禁止自行扩展

不得自行增加：

- 天气
- Analytics
- 新设置
- 新导航
- 新按钮
- 新 Theme Mode
- 动画
- Background Tasks
- Cloud Sync
- Accounts

## 4. 架构

禁止：

- 合并 App / Agent
- Agent 引用 App
- Agent 引用 AI
- Core 引用 WinUI
- Global AppContext
- Service Locator
- Circular dependency

## 5. UI

Views 不写业务逻辑。

ViewModels 不直接操作：

- Registry
- COM
- Windows Location
- raw JSON
- raw business paths
- Provider HttpClient

## 6. Renderer

Renderer 是壁纸文字布局的唯一视觉真相。

禁止每个页面重新用 XAML 模拟文字。

## 7. Design Tokens

不得发明任意：

- Margin
- Padding
- Radius
- Color
- Animation

若 Token 缺失：报告 Spec Gap。

## 8. 中文 UI

zh-CN 主界面使用自然中文。

禁止纯英文主按钮：

- Apply
- Cancel
- Settings
- Theme Store
- Safe Area
- Focal Point

代码标识符仍用英文。

## 9. Localization

不得把用户可见字符串硬编码在 XAML / C#。

使用资源文件。

## 10. NuGet

未经批准不得引入新包。

需要新包时先报告：

- package
- purpose
- license
- runtime impact
- why existing deps insufficient

## 11. Network

允许的网络类别：

- IP geolocation
- Theme Store
- Theme download
- GitHub update check
- AI generation

其它网络请求先报告。

## 12. Privacy

禁止日志：

- API Key
- Authorization
- IP
- exact coordinates
- full prompt
- poetry body
- English word body

## 13. Settings / State / Secrets

严格分离。

Secrets 使用 ISecretStore。

## 14. Time

Core scheduling 不得到处调用 DateTime.Now。

使用 IClock。

## 15. Monitor

不得使用 Display 1 / Display 2 作为持久 identity。

使用 PersistentMonitorId。

## 16. Theme

官方 Time Wallpaper Theme = 8 phases。

WDD imported themes 不一定 8 张，必须保持兼容。

Theme Package 仅数据和图片，不执行代码。

## 17. AI

- optional
- Agent !→ AI
- concurrency = 2
- partial success preserved
- regenerate preserves old image until candidate succeeds
- final Theme 不记录 AI metadata

## 18. Background Work

优先：

```text
Event-driven > polling
```

新增 recurring task 之前必须说明 wake / CPU / network impact。

## 19. Tests

行为变化必须带测试。

不得删除/弱化测试只为通过 CI。

## 20. Spec Gap

如果实现需要未定义字段或契约，输出：

```text
SPEC GAP:
- missing:
- why needed:
- smallest proposed contract:
```

不得静默新增。

## 21. New Persistent Field Checklist

- Settings or State?
- Default?
- Migration?
- Sensitive?
- Cache invalidation?

## 22. Fixed Navigation

不得增加新的顶级页面：

- 首页
- 主题
- 创作
- 每日内容
- 时间与位置
- 显示器
- 设置

## 23. Theme Studio

固定：

- Top Toolbar
- Canvas
- 312px Inspector
- 120px Phase Strip

不做 IDE 式 Dock。

## 24. Completion Checklist

任务完成前确认：

- Build succeeds
- Tests pass
- No unapproved package
- No hardcoded UI text
- No architecture violation
- No hidden polling
- No secret/privacy violation
- No NON_GOALS violation

## 25. Prime Directive

> Implement less, follow the specification, report the gap.
