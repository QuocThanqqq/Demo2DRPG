using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next_Level : MonoBehaviour
{
    public int nextLevel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && Inventory_Player.numberOfCoins > 5 )
        {

            SceneManager.LoadScene(nextLevel, LoadSceneMode.Single);
        }
    }
}
