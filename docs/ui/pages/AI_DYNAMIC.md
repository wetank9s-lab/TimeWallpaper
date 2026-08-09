# Time Wallpaper — AI_DYNAMIC.md

**Status:** Frozen

流程：

```text
Reference Image
+ Target Aspect Ratio
+ Optional Instructions
→ 8 phases
→ ThemeDraft
→ Theme Studio
```

## Target Ratio

固定：

- 16:9
- 16:10
- 21:9
- 32:9
- 跟随原图

## Additional Instructions

可选自然语言。

不是高级 Prompt Editor。

不暴露：

- Negative Prompt
- CFG
- Seed
- Steps
- Sampler

## Generation

第一次默认全部八阶段生成。

最大并发任务：

`2`

不根据 CPU / RAM 自动提高。

阶段状态：

- 等待生成
- 正在生成
- 已完成
- 生成失败
- 已取消

总体显示真实进度：

`已完成 3 / 8`

不显示虚假百分比。

## Failure

错误尽量阶段级。

例如：

`深夜：生成失败 [重试]`

部分成功必须保留。

6/8 也可以进入 Theme Studio，剩余作为空槽。

## Regenerate

成功图片重新生成时：

- 先保留旧图
- 生成 Candidate
- Candidate 成功后替换
- 失败时旧图继续保留

## Leaving

关闭生成页：

- 尚未发送任务取消
- 已成功图片进入 Recovery Draft
- V0.1 不在 Agent 后台继续生成

## Cost

不显示费用估算。

只提示：

`生成图片可能产生你所使用 AI 服务的费用。`

## Metadata

最终 Theme 不保存：

- provider
- model
- prompt
- API key
- generation metadata

Agent 不引用 AI。
