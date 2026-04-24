using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float damage = 25f;
    public float attackRate = 1.5f;

    private float lastHitTime;

    private void OnTriggerEnter(Collider other)
    {
        if (Time.time - lastHitTime < 1f / attackRate)
            return;

        Enemy enemy = other.GetComponent<Enemy>();

        if (enemy != null)
        {
            lastHitTime = Time.time;
            enemy.TakeDamage(damage);
            Debug.Log("Удар оружием по монстру");
        }
    }
}
