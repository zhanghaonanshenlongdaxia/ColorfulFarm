using UnityEngine;
using BaPK;

public class HandTapHelpController : MonoBehaviour
{
    public Label tapAndHoldLabel;
    [SerializeField] private string sortingLayerName = "12";

    void Start()
    {
        tapAndHoldLabel.GetComponent<New1FontRead>().New1Read("12", 1, TextAlignment.Center, FactoryScenesController.languageHungBV["TAPANDHOLD"], 0f, 10f);
        SetSortingLayer(sortingLayerName);
    }

    void Update()
    {
    }

    void SetSortingLayer(string layerName)
    {
        Transform[] transforms = gameObject.GetComponentsInChildren<Transform>(true);

        for (int i = 0; i < transforms.Length; i++)
        {
            SpriteRenderer spriteRenderer = transforms[i].GetComponent<SpriteRenderer>();
            if (spriteRenderer != null)
            {
                spriteRenderer.sortingLayerName = layerName;
            }
        }
    }
}
