using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 100f;

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log("Монстр получил урон: " + damage);

        if (health <= 0)
        {
            Debug.Log("Монстр убит!");
            Destroy(gameObject);
        }
    }
}