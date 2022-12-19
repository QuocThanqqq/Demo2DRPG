using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hurt_Player : MonoBehaviour
{

    private Health_manager mhealth_manager;
    public float waitToHurt = 5f;
    public bool isTouching;
    [SerializeField]
    private int damageToGive = 30;
 

    void Start()
    {
         mhealth_manager = FindObjectOfType<Health_manager>();
    }


    void Update()
    {
        if(isTouching)
        {
            waitToHurt  -= Time.deltaTime;
            if(waitToHurt <= 0)
            {
                mhealth_manager.Hurt_Player(damageToGive);
                waitToHurt = 2f;
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.tag == "Player")
        {     
            other.gameObject.GetComponent<Health_manager>().Hurt_Player(damageToGive);
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if(other.collider.tag == "Player")
        {
            isTouching = true;

        }
    }


    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.collider.tag == "Player")
        {
            isTouching = false;
            waitToHurt = 2f;
        }
    }
}
