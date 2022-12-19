using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Player_Controller : MonoBehaviour
{
   private Rigidbody2D rb;
   private Animator animator;

  [SerializeField]
    Health_manager mana;

  [SerializeField]
    private float moveSpeed = 0f;

    private float attackTime = .26f;
    private float acttackCounter = .25f;
    private bool isAttacking;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();    
    }

    void Update()
    {
       rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")) * moveSpeed * Time.deltaTime;
        
        animator.SetFloat("moveX", rb.velocity.x);
        animator.SetFloat("moveY", rb.velocity.y);



            if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
            {
                animator.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
                animator.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
            }
            if(isAttacking)
            {
                rb.velocity = Vector2.zero;
                acttackCounter -= Time.deltaTime;
                if (acttackCounter <= 0)
                {
                    animator.SetBool("isAttacking", false);
                    isAttacking = false;
                }
           
            }

            if(Input.GetKeyDown(KeyCode.L))
            {
                acttackCounter = attackTime;
                animator.SetBool("isAttacking", true);
                isAttacking = true;
                mana.currentMana -= 3;
                if (mana.currentMana <= 0)
                {
                    acttackCounter = attackTime;
                    animator.SetBool("isAttacking",false);
                    isAttacking = false;
                }
            }
    }
}
