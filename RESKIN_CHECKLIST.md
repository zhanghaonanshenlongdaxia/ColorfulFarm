# Colorful Farm Reskin Checklist

## Already done

- Unity 2022 compile compatibility baseline imported.
- Legacy Android/OpenIAB payloads removed.
- Guest-mode test flow enabled.
- Branding/package setup menu added:
  - `Tools/Colorful Farm/Apply TapTap Test Branding`
- Store/rate/feedback links centralized in `Assets/Scripts/Common/BrandingConfig.cs`.
- Old info popup replaced with temporary text description.

## Next priority

1. Replace launch and menu branding assets.
   - `Assets/Images/logo.jpg`
   - `Assets/Images/Mission/loading/bgloading.jpg`
   - `Assets/Images/Mission/loading/bgloading.png`
   - menu scene title/logo objects in `Assets/Scenes/Menu.unity`

2. Replace app icons and package-facing identity.
   - `Assets/Images/Common/icon/icon.png`
   - `Assets/Images/Common/icon/icon-36.png`
   - `Assets/Images/Common/icon/icon-48.png`
   - `Assets/Images/Common/icon/icon-72.png`
   - `Assets/Images/Common/icon/icon-96.png`
   - `Assets/Images/Common/icon/icon-144.png`
   - run `Tools/Colorful Farm/Apply TapTap Test Branding` in Unity

3. Replace visible in-game title art.
   - `Assets/Images/Farm/Farm.png`
   - `Assets/Images/Town/Market/title.png`
   - `Assets/Images/Town/Multimedia/congrat-title.png`
   - lottery title textures under `Assets/Images/Town/Lottery`

4. Replace mission/loading look.
   - `Assets/Images/Mission/loading/*`
   - `Assets/Images/Mission/background/bgmission*.jpg`

5. Review scene/prefab text and about content.
   - `Assets/Resources/Mission/Language/EN.xml`
   - `Assets/Resources/Mission/Language/VI.xml`
   - `Assets/Resources/Farm/XMLFile/TextGuide1.xml`

## Build notes

- Current Android package id: `com.colorfulfarm.taptap`
- Current product name: `Colorful Farm`
- Current build is aimed at offline/guest testing, not production billing.

## Recommended next implementation step

- Replace icon set and `logo.jpg` first.
- Then open Unity and run:
  - `Tools -> Colorful Farm -> Apply TapTap Test Branding`
- Then verify scenes:
  - `LogoScene`
  - `LoadingScene`
  - `Menu`
  - `Mission`
