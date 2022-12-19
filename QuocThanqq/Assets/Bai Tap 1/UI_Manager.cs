using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Manager : MonoBehaviour
{
    private Health_manager mhealth_Manager;
    public Slider healthBar;
    public Text hpText;
    public Slider manaBar;
    public Text manaText;

  
    void Start()
    {
        mhealth_Manager = FindObjectOfType<Health_manager>();
    }

    
    void Update()
    {
        healthBar.maxValue = mhealth_Manager.maxHealth;
        healthBar.value = mhealth_Manager.currentHealth;
        hpText.text = "HP: " + mhealth_Manager.currentHealth  + "/" + mhealth_Manager.maxHealth;


        manaBar.maxValue = mhealth_Manager.maxMana;
        manaBar.value = mhealth_Manager.currentMana;
        manaText.text = "Mana: " + mhealth_Manager.currentMana + "/" + mhealth_Manager.maxMana;
   
    }
}
