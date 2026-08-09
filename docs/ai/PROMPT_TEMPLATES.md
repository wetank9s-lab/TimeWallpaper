# Time Wallpaper — PROMPT_TEMPLATES.md

**Status:** Frozen

## Standard Implementation Prompt

```text
PROJECT
Time Wallpaper / 时辰壁纸

TASK
<one specific implementation goal>

SPEC REFERENCES
- docs/architecture/ARCHITECTURE.md
- docs/architecture/CONFIG_AND_STATE.md
- docs/product/NON_GOALS.md
- <task-specific spec>

FILES ALLOWED TO CHANGE
- ...

CONTRACT
- ...

ACCEPTANCE CRITERIA
1. ...
2. ...

TESTS
- ...

FORBIDDEN CHANGES
- No new NuGet packages.
- No unrelated architecture changes.
- No hidden polling.
- No extra features.
- Do not modify specs.

OUTPUT
1. Implemented
2. Files changed
3. Tests
4. Remaining issue / None
```

## WinUI Prompt

必须附：

- UI_DESIGN_SYSTEM.md
- page spec
- ViewModel contract
- component IDs
- responsive states

要求：

- resource strings
- no business logic in code-behind
- no direct Windows API
- no invented dimensions/colors/animations

## Platform Prompt

必须说明：

- owning project
- interface
- Windows API responsibility
- callers
- error contract
- testability

## Theme Security Prompt

测试：

- valid
- missing manifest
- corrupt zip
- traversal
- absolute path
- exe/script
- invalid image
- duplicate phase
- invalid Safe Area / Focal Point

## Agent Prompt

要求：

- no WinUI
- no AI
- event-driven
- no continuous polling
- performance note

## Persistent Field Prompt

必须先回答：

- Settings / State / Secret?
- default?
- schema impact?
- migration?
- sensitive?
- cache impact?

## Review Prompt

按 P0/P1/P2/P3 检查：

- architecture
- hidden polling
- privacy
- hardcoded strings
- new packages
- DateTime.Now in Core
- monitor ordinal persistence
- duplicated Renderer logic

## Prompt Size

通常一个任务：

- 1 service
- 1 page
- 1 component
- 1 domain model group
- 1 test group

不要一次让 DeepSeek “实现整个 Phase”。
