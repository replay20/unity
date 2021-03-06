﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 3;
    public int score=50;
    public GameObject deathEffect;
    public PlayerMovement player;
    /*public Transform damagePoint;
    public float damageRadius = 0.5f;
    public LayerMask playerLayers;*/



    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
        Debug.Log(health);
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        player.UpdateScore(score);
    }

}
