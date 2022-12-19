using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Pickup : MonoBehaviour
{
    Health_manager mhealth_manager;
    private int healthRecovery = 30;
    private int manaRecovery = 30;
 



    void Awake()
    {
        mhealth_manager = FindObjectOfType<Health_manager>();   
    }
      void OnTriggerEnter2D(Collider2D other)
      {
        if (other.tag == "Player")
        {
            if(mhealth_manager.currentHealth <= (mhealth_manager.maxHealth - 10 ))
            {
                mhealth_manager.currentHealth  += healthRecovery;

                Destroy(gameObject);
            }
              if (mhealth_manager.currentMana <= (mhealth_manager.maxMana - 30))
              {
                    mhealth_manager.currentMana += manaRecovery;

                    Destroy(gameObject);
              }
        }
       

      }
}
