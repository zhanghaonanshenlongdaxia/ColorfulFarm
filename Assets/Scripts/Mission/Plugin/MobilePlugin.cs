using UnityEngine;
using System.Collections;

public class MobilePlugin
{
    private static MobilePlugin instance;
#if UNITY_ANDROID
    private AndroidJavaClass objJavaClass;
    private AndroidJavaObject objJavaObject;
#endif

    public static MobilePlugin getInstance()
    {
        if(instance == null)
        {
            instance = new MobilePlugin();
        }
        return instance;
    }

    private MobilePlugin()
    {
#if UNITY_ANDROID
        objJavaClass = new AndroidJavaClass("com.example.androidunityplugin.AndroidUnity");
        objJavaObject = new AndroidJavaObject("com.example.androidunityplugin.AndroidUnity");
    }
#else
    }
#endif

    public void ShowToast(string message, bool length_show = false)
    {
#if UNITY_ANDROID
        objJavaClass.CallStatic("Toast", message, length_show);
#else
        Debug.Log(message);
#endif
	}

    public void ShowExitConfirm(string title, string message, string ok, string cancel)
    {
#if UNITY_ANDROID
        objJavaClass.CallStatic("ShowCofirm", title, message, ok, cancel);
#else
        Debug.Log(title + ": " + message);
#endif
    }
}
