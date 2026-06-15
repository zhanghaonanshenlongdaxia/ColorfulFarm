using UnityEngine;

[ExecuteInEditMode]
public class SortingOrderUpdate : MonoBehaviour
{
    public float SortingOrder = 0;

    private Renderer cachedRenderer;

    private void Start()
    {
        cachedRenderer = GetComponent<Renderer>();
        if (!cachedRenderer)
        {
            Destroy(this);
        }
    }

    private void Update()
    {
        if (cachedRenderer == null)
        {
            cachedRenderer = GetComponent<Renderer>();
            if (cachedRenderer == null)
            {
                return;
            }
        }

        cachedRenderer.sortingOrder = Mathf.RoundToInt(SortingOrder);
    }
}
