using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public int attackDamage = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Enemy enemy = other.GetComponent<Enemy>();

        if (enemy != null)
        {
            enemy.TakeDamage(attackDamage);
            gameObject.SetActive(false);
        }
    }
}
