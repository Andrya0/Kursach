using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PickupObject : MonoBehaviour
{
    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        Debug.Log("Soso!");
        Destroy(gameObject, 1f);
    }
}
