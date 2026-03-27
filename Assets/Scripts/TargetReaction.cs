using UnityEngine;

public class TargetReaction: MonoBehaviour
{
    private Renderer targetRenderer;

    private void Awake()
    {
        targetRenderer = GetComponent<Renderer>();
    }

    public void ChangeColor()
    {
        if (targetRenderer != null)
        {
            targetRenderer.material.color = Color.red;
        }
    }

    public void HideTarget()
    {
        gameObject.SetActive(false);
    }
}