using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruits : MonoBehaviour
{
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 12);
        rb.angularVelocity = 100;
    }
    private void Update()
    {
        if(transform.position.y < -7)
        {
            Die();
        }
    }

    void Die()
    {
        print(":(");
        Destroy(gameObject);
    }
}
