# Time Wallpaper — AI_DYNAMIC.md

**Status:** Frozen

## Flow

```text
Reference Image
+ Target Ratio
+ Optional Instructions
→ 8 phases
→ ThemeDraft
→ Theme Studio
```

## Ratio

- 16:9
- 16:10
- 21:9
- 32:9
- 跟随原图

## Optional Instructions

自然语言补充。

不做高级 Prompt 控件。

## Generation

第一次默认 8 个全生成。

`TW.AI.MaxConcurrentGenerationTasks = 2`

不动态提高。

状态：

- 等待生成
- 正在生成
- 已完成
- 生成失败
- 已取消

显示 `已完成 n / 8`，不显示虚假百分比。

## Partial Failure

错误尽量阶段级。

部分成功必须保留。

6/8 可进入 Studio，2 个空槽继续补。

## Regenerate

旧图保留。

Candidate 成功后再 replace。

失败时旧图不丢。

## Leaving

关闭生成页：

- Pending cancel
- successful phases → Recovery Draft
- V0.1 不交给 Agent 后台继续

## Cost

不估算费用。

只提示可能产生用户自己的 AI 服务费用。

## Theme Metadata

最终 Theme 不写：

- provider
- model
- prompt
- api key
- generation metadata
