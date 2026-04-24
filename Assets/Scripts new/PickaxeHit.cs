using UnityEngine;

public class PickaxeHit : MonoBehaviour
{
    public Pickaxe pickaxe;

    private void OnTriggerEnter(Collider other)
    {
        if (pickaxe == null)
            return;

        pickaxe.TryHit(other.gameObject);
    }
}