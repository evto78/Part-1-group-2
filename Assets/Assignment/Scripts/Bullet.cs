using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float force = 0f;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetForce(float incomingForce)
    {
        force = incomingForce;
        Debug.Log(force);
        Vector2 appliedForce = transform.right * force;
        rb.AddForce(appliedForce);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
