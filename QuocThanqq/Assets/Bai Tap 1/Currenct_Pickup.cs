using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currenct_Pickup : MonoBehaviour
{
 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Inventory_Player.numberOfCoins += Random.Range(1,5);
            Destroy(gameObject);
        }
        
    }
}
