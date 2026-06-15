using UnityEngine;

public class DialogInapp : DialogAbs
{
    float[] prices = { 0.99f, 4.99f, 9.99f, 19.99f, 29.99f, 49.99f };
    int[] quatity = { 20, 120, 250, 450, 650, 1100 };
    Transform main, black;
    string tag = "Inapp";

    void Awake()
    {
        transform.parent = GameObject.Find("AudioControl").transform;
        main = transform.Find("Main");
        black = transform.Find("Black");
        for (int i = 0; i < prices.Length; i++)
        {
            transform.Find("Main").Find("package" + (i + 1)).Find("quatity").GetComponent<UILabel>().text = "" + quatity[i];
            transform.Find("Main").Find("package" + (i + 1)).Find("buy").Find("Label").GetComponent<UILabel>().text = "$ " + prices[i];
        }

        gameObject.tag = tag;
        GameObject[] dialogs = GameObject.FindGameObjectsWithTag(tag);
        if (dialogs.Length > 1)
        {
            for (int i = 1; i < dialogs.Length; i++)
            {
                Destroy(dialogs[i]);
            }
        }
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (Show && Input.GetKeyDown(KeyCode.Escape))
        {
            HideDialog();
        }
    }

    void OnApplicationPause(bool pauseStatus)
    {
        if (!pauseStatus)
        {
            HideDialog();
        }
    }

    public void ButtonBuy(Transform button)
    {
#if UNITY_ANDROID
        MobilePlugin.getInstance().ShowToast("The store is disabled in this test build.");
#endif
        Debug.Log("Store purchase disabled: " + button.parent.name);
    }

    public override void ShowDialog(DialogAbs.CallBackShowDialog callback = null)
    {
        CommonObjectScript.isViewPoppup = true;
        if (Show)
        {
            return;
        }

        Show = true;
        main.gameObject.SetActive(true);
        black.gameObject.SetActive(true);
        main.Find("Title").GetComponent<UILabel>().text = MissionControl.Language["RESOURCE"];
        main.Find("package1").GetComponent<UILabel>().text = MissionControl.Language["package1"];
        main.Find("package2").GetComponent<UILabel>().text = MissionControl.Language["package2"];
        main.Find("package3").GetComponent<UILabel>().text = MissionControl.Language["package3"];
        main.Find("package4").GetComponent<UILabel>().text = MissionControl.Language["package4"];
        main.Find("package5").GetComponent<UILabel>().text = MissionControl.Language["package5"];
        main.Find("package6").GetComponent<UILabel>().text = MissionControl.Language["package6"];

        LeanTween.scale(main.gameObject, Vector3.one, 0.3f)
            .setUseEstimatedTime(true)
            .setEase(LeanTweenType.easeOutBack)
            .setOnComplete(() => { Time.timeScale = 0; });
    }

    public override void HideDialog(DialogAbs.CallBackHideDialog callback = null)
    {
        if (!Show)
        {
            return;
        }

        Time.timeScale = 1;
        LeanTween.scale(main.gameObject, Vector3.zero, 0.3f)
            .setUseEstimatedTime(true)
            .setEase(LeanTweenType.easeInBack)
            .setOnComplete(() =>
            {
                CommonObjectScript.isViewPoppup = false;
                black.gameObject.SetActive(false);
                Show = false;
                main.gameObject.SetActive(false);
            });
    }

    public static void ShowInapp()
    {
#if UNITY_ANDROID
        MobilePlugin.getInstance().ShowToast("The store is disabled in this test build.");
#endif
        Debug.Log("The store is disabled in this test build.");
    }
}
