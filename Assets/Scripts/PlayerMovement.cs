using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public int playerLife = 5;
    public GameObject deathEffect;
    float timeBetweenAttacks = 0.5f;
    float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("isCrouching", isCrouching);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    void OnCollisionEnter2D (Collision2D collision)
    {

        if (collision.gameObject.tag == "Enemy" && timer >= timeBetweenAttacks)
        {
            
            Debug.Log(playerLife-=1);
            timer = 0f;

            //zamienic na switch case
            if (collision.transform.position.x > transform.position.x)
                controller.knockbackDirectionX = -1;
            else if (collision.transform.position.x == transform.position.x)
                controller.knockbackDirectionX = 0;
            else if (collision.transform.position.x < transform.position.x)
                controller.knockbackDirectionX = 1;

            if (collision.transform.position.y > transform.position.y)
                controller.knockbackDirectionY = -1;
            else if (collision.transform.position.y == transform.position.y)
                controller.knockbackDirectionY = 0;
            else if (collision.transform.position.y < transform.position.y)
                controller.knockbackDirectionY = 1;
            controller.Knockback();
            //Debug.Log(controller.knockbackDirectionX);
            //Debug.Log(controller.knockbackDirectionY);
        }

        if (playerLife <= 0)
            Die();
    }
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
