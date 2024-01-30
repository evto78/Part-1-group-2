using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float turnSpeed = 50.0f;
    float charge = 0.0f;
    public GameObject bullet;
    public Transform firePoint;
    
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, Input.GetAxis("Horizontal") * -turnSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
        }
    }
}
