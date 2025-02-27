using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float turnSpeed = 50.0f;
    //Charge is how much force the bullet will be launched with
    float charge = 0.0f;
    float maxCharge = 700.0f;
    public GameObject bullet;
    public Transform firePoint;
    
    void Start()
    {
        
    }

    void Update()
    {
        //Aims the turret with A and D
        transform.Rotate(0, 0, Input.GetAxis("Horizontal") * -turnSpeed * Time.deltaTime);

        //Spawns in bullet with SPACE and the longer you hold it the more force is given to the bullet
        if (Input.GetKey(KeyCode.Space))
        {
            if (charge < maxCharge)
            {
                //each frame you hold the SPACE key down charge gets higher until it reaches a max
                Debug.Log("Current charge " + charge);
                charge += (500 * Time.deltaTime);
                if (charge > maxCharge)
                {
                    charge = maxCharge;
                }
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Bullet spawned with " + charge + " force.");
            //spawn in the bullet at the firepoint
            var bulletSpawned = Instantiate(bullet, firePoint.position, firePoint.rotation);
            //get the component of the bullets script and run the function "SetForce" to charge
            bulletSpawned.GetComponent<Bullet>().SetForce(charge);
            charge = 0.0f;
        }
    }
}
