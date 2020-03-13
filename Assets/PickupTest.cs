using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTest : MonoBehaviour
{

    public GameObject bball;
    private Rigidbody brb;

    public bool pickable;
    public bool holding;

    public Transform theball;
    public Transform thecamera;

    public RigidbodyConstraints ogbrb;

    public float throwspeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        brb = bball.GetComponent<Rigidbody>();
        ogbrb = brb.constraints;
    }

    // Update is called once per frame
    void FixedUpdate()
    {



        if (holding == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                brb.constraints = ogbrb;
                brb.useGravity = true;
                theball.parent = null;
                brb.AddForce(thecamera.forward * throwspeed, ForceMode.Impulse);
            }
        }

        if (pickable == true)
        {
            if (Input.GetKey(KeyCode.Mouse1))
            {
                StartCoroutine(pickingitup());
            }
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            pickable = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            pickable = false;
        }
    }

    public IEnumerator pickingitup()
    {
        brb.useGravity = false;
        theball.SetParent(thecamera);
        brb.velocity = new Vector3(0, 7, 0);
        yield return new WaitForSeconds(.12f);
        brb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionY;
        holding = true;
    }


}
