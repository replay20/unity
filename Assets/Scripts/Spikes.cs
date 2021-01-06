using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public int damage = 50;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerMovement player = col.GetComponent<PlayerMovement>();
            if (player != null)
                player.TakeDamage(player.playerLife);
        }
        else return;
    }
}
