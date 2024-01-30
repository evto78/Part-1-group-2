using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject plate;
    public bool on = false;
    public Transform trans;
    public float speed = 2f;

    public float trackMax = 8f;
    public float trackMin = 0f;
    void Update()
    {
        on = plate.GetComponent<PressurePlate>().on;
        if (on)
        {
            //if pressure plate is activated then increase X until in maximum position
            Debug.Log("ON");
            if (trans.position.x < trackMax)
            {
                trans.Translate(speed * Time.deltaTime, 0, 0);
            }
        }
        else
        {
            //if pressure plate isnt activated then decrease X until in minimum position
            Debug.Log("OFF");
            if (trans.position.x > trackMin)
            {
                trans.Translate(-speed * Time.deltaTime, 0, 0);
            }
        }
        
    }
}
