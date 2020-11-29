using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCheckDistance : MonoBehaviour
{
    public Transform target;
    public Rigidbody2D rb;
    public EnemyAI enemy;

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = Vector2.Distance(rb.position, target.position);
        enemy = GetComponent<EnemyAI>();
        if (distance<=16)
            enemy.enabled = true;
        else
            enemy.enabled = false;
        //Debug.Log(distance);
    }
}
