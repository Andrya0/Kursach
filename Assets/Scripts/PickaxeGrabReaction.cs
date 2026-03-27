using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class PickaxeGrabReaction : MonoBehaviour
{
    public TargetReaction targetReaction;

    private XRGrabInteractable grabInteractable;
    private bool alreadyTriggered = false;

    private void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
    }

    private void OnEnable()
    {
        if (grabInteractable != null)
            grabInteractable.selectEntered.AddListener(OnGrabbed);
    }

    private void OnDisable()
    {
        if (grabInteractable != null)
            grabInteractable.selectEntered.RemoveListener(OnGrabbed);
    }

    private void OnGrabbed(SelectEnterEventArgs args)
    {
        if (alreadyTriggered) return;

        alreadyTriggered = true;

        if (targetReaction != null)
        {
            targetReaction.ChangeColor();
        }
    }
}