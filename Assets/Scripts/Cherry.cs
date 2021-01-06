using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cherry : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D col)
    {
        PlayerMovement player = col.GetComponent<PlayerMovement>();

        if (col.gameObject.tag == "Player")
        {
            player.playerLife += 1;
            Destroy(gameObject);
        }
    }
}
