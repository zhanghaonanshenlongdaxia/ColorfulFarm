using UnityEngine;

public class HelpGirlController : MonoBehaviour
{
    public static Animator animator;

    [SerializeField] private string sortingLayerName = "Machine4";

    void Start()
    {
        animator = GetComponent<Animator>();
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

    void ResetAnimation()
    {
        //animator.SetTrigger("Stand");
    }
}
