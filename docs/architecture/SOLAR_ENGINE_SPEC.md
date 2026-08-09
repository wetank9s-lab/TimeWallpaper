# Time Wallpaper — SOLAR_ENGINE_SPEC.md

**Status:** Frozen  
**Owner:** TimeWallpaper.Core

## 1. Eight Phases

- Dawn / 黎明
- Sunrise / 日出
- Morning / 上午
- Noon / 正午
- Afternoon / 下午
- Sunset / 日落
- Dusk / 暮色
- Night / 深夜

## 2. Normal Astronomical Semantics

Dawn = beginning of civil twilight  
Sunrise = apparent sunrise  
Noon = solar noon / transit  
Sunset = apparent sunset  
Dusk = end of civil twilight  
Night = astronomical dusk

Reference altitudes:

- Civil Twilight ≈ -6°
- Astronomical Twilight ≈ -18°
- Apparent sunrise/sunset standard zenith ≈ 90.8333°

## 3. Normal Derived Phases

```text
Morning
= midpoint(Sunrise, Solar Noon)

Afternoon
= midpoint(Solar Noon, Sunset)
```

## 4. Night

正常地区：

```text
Night = Astronomical Dusk
```

不使用 Civil Dusk + 固定 30/60/90 分钟。

## 5. White-Night Fallback

如果：

- normal daylight events exist
- astronomical dusk missing
- next civil dawn exists

则：

```text
Night = midpoint(Current Civil Dusk, Next Civil Dawn)
```

其它阶段保持真实事件。

FallbackType = WhiteNight

## 6. Solar Cycle May Cross Midnight

Solar Schedule 不要求所有 timestamp 在同一日。

例如：

```text
Dusk  23:10
Night 01:10 next day
Dawn  03:10 next day
```

必须用 absolute timezone-aware timestamps 排序，不可只比较 TimeOfDay。

Daily Content 仍在当地 00:00 独立换日。

## 7. Twilight-Only Fallback

如果：

- Civil Dawn exists
- Sunrise missing
- Solar Noon exists
- Sunset missing
- Civil Dusk exists

则：

```text
Dawn = real Civil Dawn
Sunrise = Dawn + 25% * (Noon - Dawn)
Morning = midpoint(Sunrise, Noon)
Noon = real Solar Noon
Afternoon = midpoint(Noon, Sunset)
Sunset = Noon + 75% * (Dusk - Noon)
Dusk = real Civil Dusk
Night = midpoint(Dusk, Next Civil Dawn)
```

Synthetic Sunrise / Sunset 仅内部标记，普通 UI 仍显示日出 / 日落。

FallbackType = TwilightOnly

## 8. Polar Day Fallback

以 Solar Noon `N` 为锚：

```text
Dawn       N - 10h
Sunrise    N - 8h
Morning    N - 4h
Noon       N
Afternoon  N + 4h
Sunset     N + 8h
Dusk       N + 10h
Night      N + 11h
```

FallbackType = PolarDay

## 9. Polar Night Fallback

以 Solar Noon `N` 为锚：

```text
Dawn       N - 4h
Sunrise    N - 3h
Morning    N - 1h30m
Noon       N
Afternoon  N + 1h30m
Sunset     N + 3h
Dusk       N + 4h
Night      N + 6h
```

FallbackType = PolarNight

## 10. Defensive Fallback

如果 Solar calculator 返回异常 / invalid：

```text
Dawn       05:00
Sunrise    06:00
Morning    09:00
Noon       12:00
Afternoon  15:00
Sunset     18:00
Dusk       19:00
Night      21:00
```

FallbackType = Defensive

## 11. Fallback Types

```text
None
WhiteNight
TwilightOnly
PolarDay
PolarNight
Defensive
```

## 12. Event Origin

建议：

```text
Astronomical
Derived
Synthetic
```

供测试 / Debug 使用，不进入普通 UI。

## 13. Ordering Invariant

```text
Dawn
<
Sunrise
<
Morning
<
Noon
<
Afternoon
<
Sunset
<
Dusk
<
Night
<
Next Dawn
```

比较 absolute `DateTimeOffset` 或等价 timezone-aware instant。

## 14. Minimum Gap

`MinimumTransitionGap = 5 minutes`

如果无法满足且不能保持真实事件，应升级 fallback，不要人为移动真实事件。

## 15. Timezone

- 使用目标位置 timezone rules
- 不用固定 UTC offset 代替 timezone
- Core 不依赖机器当前 local timezone

## 16. Agent Scheduling

Agent next wake：

```text
min(
    NextSolarTransition,
    NextLocalMidnight,
    other required event
)
```

不每分钟重新计算。

## 17. Tests

必须覆盖：

- normal summer
- normal winter
- exact boundaries
- cross-midnight
- white night
- twilight-only
- polar day
- polar night
- defensive fallback
- timezone
- DST
- minimum gap
- host timezone independence
