using UnityEngine;

public class PickaxeUpgrade : MonoBehaviour
{
    public float damageBonus = 5f;
    public float speedBonus = 0.5f;

    public void ApplyUpgrade(Pickaxe pickaxe)
    {
        pickaxe.Upgrade(damageBonus, speedBonus);
        Debug.Log("Улучшение применено!");
        Destroy(gameObject);
    }
}