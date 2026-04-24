using UnityEngine;

public class Crystal : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log("Кристалл получил урон: " + damage);

        if (health <= 0)
        {
            Debug.Log("Кристалл добыт!");
            Destroy(gameObject);
        }
    }
}