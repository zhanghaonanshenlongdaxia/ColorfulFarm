using UnityEditor;

public static class BrandingSetup
{
    [MenuItem("Tools/Colorful Farm/Apply TapTap Test Branding")]
    public static void ApplyTapTapTestBranding()
    {
        PlayerSettings.companyName = "Colorful Farm Studio";
        PlayerSettings.productName = "Colorful Farm";
        PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.colorfulfarm.taptap");
        PlayerSettings.bundleVersion = "1.0.0";
        PlayerSettings.SetScriptingBackend(BuildTargetGroup.Android, ScriptingImplementation.IL2CPP);
        PlayerSettings.Android.bundleVersionCode = 1;
        PlayerSettings.Android.minSdkVersion = AndroidSdkVersions.AndroidApiLevel23;
        PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARMv7 | AndroidArchitecture.ARM64;

        AssetDatabase.SaveAssets();
    }
}
