using UnityEngine;

public class Pickaxe : MonoBehaviour
{
    public float crystalDamage = 10f;
    public float enemyDamage = 5f;
    public float attackRate = 1f;

    private float lastHitTime;

    public void TryHit(GameObject target)
    {
        // 1. улучшение
        PickaxeUpgrade upgrade = target.GetComponentInParent<PickaxeUpgrade>();
        if (upgrade != null)
        {
            upgrade.ApplyUpgrade(this);
            return;
        }

        // 2. кристалл
        Crystal crystal = target.GetComponentInParent<Crystal>();
        if (crystal != null)
        {
            crystal.TakeDamage(crystalDamage);
            return;
        }

        // 3. монстр
        Enemy enemy = target.GetComponentInParent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(enemyDamage);
        }
    }

    public void Upgrade(float damageBonus, float speedBonus)
    {
        crystalDamage += damageBonus;
        attackRate += speedBonus;

        Debug.Log("Кирка улучшена! Урон: " + crystalDamage + ", скорость: " + attackRate);
    }
}