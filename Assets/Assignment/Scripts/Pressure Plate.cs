using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public bool on = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (on)
        {
            on = false;
        }
        else
        {
            on = true;
        }
    }
}
