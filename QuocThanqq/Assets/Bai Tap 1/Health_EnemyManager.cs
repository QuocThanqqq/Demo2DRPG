using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_EnemyManager : MonoBehaviour
{
    public int currentHealth;
    public int maxhealth;
    public HealthBar_Enemy mHealthBar_Enemy;

    public GameObject lootDrop;


    void Start()
    {
        currentHealth = maxhealth;
        mHealthBar_Enemy.SetHealth(currentHealth, maxhealth);
    }

    public void Hurt_Enemy(int damageToGive)
    {
        currentHealth -= damageToGive;
        mHealthBar_Enemy.SetHealth(currentHealth, maxhealth);
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Instantiate(lootDrop,transform.position,Quaternion.identity);
         
        }
    }
}
