public static class ReleaseConfig
{
    public const bool UseLegacySocial = false;
    public const bool UseLegacyBilling = false;
    public const bool UseLegacyAds = false;
    public const bool UseLegacyAnalytics = false;
    public const bool UsePackageHackCheck = false;

    public static bool UseGuestMode
    {
        get { return !UseLegacySocial; }
    }
}
