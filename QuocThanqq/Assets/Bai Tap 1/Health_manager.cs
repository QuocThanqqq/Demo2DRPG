using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health_manager : MonoBehaviour
{
  
    public int currentHealth;
    public int maxHealth;

    public int currentMana;
    public int maxMana;



    public void Hurt_Player(int damageToGive)
    {
        currentHealth -= damageToGive;
        if(currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);    
        }
    }
}
