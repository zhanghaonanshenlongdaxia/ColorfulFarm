using UnityEngine;
using System.Collections;

public class MobilePlugin
{
    private static MobilePlugin instance;

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
    }

    public void ShowToast(string message, bool length_show = false)
    {
        Debug.Log(message);
	}

    public void ShowExitConfirm(string title, string message, string ok, string cancel)
    {
        Debug.Log(title + ": " + message);
    }
}
