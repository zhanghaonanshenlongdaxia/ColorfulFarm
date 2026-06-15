public static class BrandingConfig
{
    public const string ProductName = "Colorful Farm";
    public const string AndroidPackageName = "com.colorfulfarm.taptap";
    public const string FeedbackEmail = "";
    public const string AndroidRateUrl = "market://details?id=" + AndroidPackageName;
    public const string InfoTitle = "Colorful Farm";
    public const string InfoBody =
        "This test build is being prepared for a TapTap reskin.\n\n" +
        "Current state:\n" +
        "- Guest mode enabled\n" +
        "- Legacy billing, ads, analytics and social are disabled\n" +
        "- Branding and store links are being replaced\n\n" +
        "Next step: replace icons, logo, loading art and in-game title assets.";

    public static string BuildFeedbackMailto(string body)
    {
        return "mailto:" + FeedbackEmail + "?subject=" + ProductName + " Feedback&body=" + body;
    }
}
