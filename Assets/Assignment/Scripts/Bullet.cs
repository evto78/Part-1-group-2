using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float force = 0f;

    private void Awake()
    {
        
    }

    public void SetForce(float incomingForce)
    {
        force = incomingForce;
        Debug.Log(force);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
