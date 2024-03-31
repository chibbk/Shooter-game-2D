using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;
    [SerializeField]
    Transform GunPoint;
    [SerializeField]
    float GunForce;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            //b is the clone(s) of the bullet
            GameObject b = Instantiate(bullet, GunPoint.position, transform.rotation);
            //add physics to bullet
            b.GetComponent<Rigidbody2D>().AddForce(transform.up * GunForce, ForceMode2D.Impulse);
        }
    }
}
