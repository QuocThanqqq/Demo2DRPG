using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt_Enemy : MonoBehaviour
{
    public int damageToGive = 10;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if ( other.tag == "Chest")
        {
            Health_EnemyManager health_EnemyManager;
            health_EnemyManager = other.gameObject.GetComponent<Health_EnemyManager>();
            health_EnemyManager.Hurt_Enemy(damageToGive);
        }
    }
}
