using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMeter : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject ShootingMeter;
    public GameObject ShootingFill;
    public bool Shoot;

    // Start is called before the first frame update
    void Start()
    {
        rb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        ShootingMeter.GetComponent<Canvas>().enabled = false;
        ShootingFill.GetComponent<Canvas>().enabled = false;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Shoot = true;
        }
        if (Shoot == true)
        {
            ShootingMeter.GetComponent<Canvas>().enabled = true;
        }
        if (Input.GetButton("E"))
        {
            ShootingFill.GetComponent<Canvas>().enabled = true;
        }
    }
}


