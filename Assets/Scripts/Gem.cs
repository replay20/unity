using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerMovement player = col.GetComponent<PlayerMovement>();

        if (col.gameObject.tag == "Player")
        {
            player.score += 250;
            Destroy(gameObject);
        }
    }
}
