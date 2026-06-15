public static class BrandingConfig
{
    public const string ProductName = "Colorful Farm";
    public const string AndroidPackageName = "com.colorfulfarm.taptap";
    public const string FeedbackEmail = "";
    public const string AndroidRateUrl = "market://details?id=" + AndroidPackageName;

    public static string BuildFeedbackMailto(string body)
    {
        return "mailto:" + FeedbackEmail + "?subject=" + ProductName + " Feedback&body=" + body;
    }
}
