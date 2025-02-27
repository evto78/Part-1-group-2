using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour
{

    public float speed = 5.0f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(speed * Time.deltaTime, 0);
        rb.MovePosition(rb.position + direction);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("missle collision");
        Destroy(gameObject);
    }
}
