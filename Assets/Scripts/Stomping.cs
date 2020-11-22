using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stomping : MonoBehaviour
{
    public int damage = 3;
    public CharacterController2D controller;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            controller.StompJump();
            Enemy enemy = col.GetComponent<Enemy>();
            if (enemy != null)
                enemy.TakeDamage(damage);
        }
        else return;
    }
}
