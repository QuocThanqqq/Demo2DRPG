using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NoticeWindows : MonoBehaviour
{
    public Button yubButton;
    public TextMeshProUGUI yubMeshPro;

    void Start()
    {
        OpenNoticeWinodws("You need to collect 8 coins to pass the new level.");
    }

    private void OpenNoticeWinodws(string message)
    {
        gameObject.SetActive(true);
        yubButton.onClick.AddListener(YubClick);
        yubMeshPro.text = message;
    }    
    private void YubClick()
    {
        gameObject.SetActive(false);
    }    
}
