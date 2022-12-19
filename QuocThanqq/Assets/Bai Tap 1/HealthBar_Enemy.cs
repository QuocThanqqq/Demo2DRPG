using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar_Enemy : MonoBehaviour
{
    public Slider mSlider;
    public Color Low;
    public Color High;
    public Vector3 Offset;

    public void SetHealth(int health, int maxHealth)
    {
        mSlider.gameObject.SetActive(health < maxHealth);
        mSlider.value = health;
        mSlider.maxValue = maxHealth;
        mSlider.fillRect.GetComponentInChildren<Image>().color = Color.Lerp(Low, High, mSlider.normalizedValue);
    }
  
    void Update()
    {
        mSlider.transform.position = Camera.main.WorldToScreenPoint(transform.parent.position + Offset);
    }
}
