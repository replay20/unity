using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadDetect : MonoBehaviour
{
    GameObject gameobject;
    
    //gameobject.GetComponent<Enemy>();
    // Start is called before the first frame update
    void Start()
    {
        gameobject = gameObject.transform.parent.gameObject;

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        gameobject.GetComponent<Enemy>().TakeDamage(3);
        Debug.Log(gameobject.GetComponent<Enemy>().health);
    }
}
