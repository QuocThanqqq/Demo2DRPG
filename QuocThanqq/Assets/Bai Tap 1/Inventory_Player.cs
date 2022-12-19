using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory_Player : MonoBehaviour
{

    public static int numberOfCoins;
    public TextMeshProUGUI coinText;

    void Update()
    {
        coinText.text = numberOfCoins.ToString();
    }
}
