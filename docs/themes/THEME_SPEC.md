# Time Wallpaper — THEME_SPEC.md

**Status:** Frozen

## Format

`*.twtheme` = ZIP data package.

Example:

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

## Required Conceptual Fields

- schemaVersion
- themeId
- version
- name
- author? 
- license?
- display.aspectRatio
- display.recommendedResolution
- display.cropMode
- display.focalPoint
- display.contentSafeArea
- phases
- metadata

## Official Standard

八阶段：

- dawn
- sunrise
- morning
- noon
- afternoon
- sunset
- dusk
- night

## Theme-level Display Settings

V0.1 一个 Theme 共用：

- one Focal Point
- one Safe Area

normalized 0–1 coordinates。

## Theme Package Security

Theme 只能包含：

- images
- JSON metadata
- preview

禁止：

- exe
- dll
- ps1
- bat
- js
- executable code

必须防：

- path traversal
- absolute path overwrite
- corrupt ZIP
- bad image
- invalid manifest

## Preview

优先：

1. preview.webp
2. afternoon phase image

## Ownership

- BuiltIn
- Downloaded
- UserCreated
- Draft

Built-in / downloaded 要编辑时创建副本并生成新 themeId。

## Save vs Export

Save：

- 本地主题
- 出现在“已安装”

Export：

- 生成 `.twtheme`

Save 不等于 Apply。

## WDD

WDD `.ddw` / compatible ZIP → WddThemeImporter → normalized ThemeDefinition。

不要把 24 张旧主题强制压成 8 张。
