using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //References
    public Transform target;
    public GameObject CameraHolder;

    //Attributes
    public float TurnSensitivity = 10;
    public float TiltSensitivity = 0.7f;

    //Camera positions
    public float Height = 7;
    public float Distance = 7;
    public float maxRadius = 9;
    public float currentRadius = 3;
    public float minRadius = 1;


    void Awake() {
        SelfCheckUp();
    }

    void FixedUpdate() {
        ThirdPersonControl();
    }

    void ThirdPersonControl() {
        //Follows the player
        transform.position = target.position;

        //Tilts Up and Down
        float horizontal = Input.GetAxis("Mouse X");
        float vertical = Input.GetAxis("Mouse Y");
        CameraTilt(horizontal, vertical);
    }

    void CameraTilt(float hor, float ver) {
        //Follows the player at the center
        transform.position = target.position;

        //Turns Left and Right
        transform.Rotate(new Vector3(0, TurnSensitivity * hor, 0));
        target.rotation = transform.rotation;

        //Tilts
        currentRadius = maxRadius;

        //Makes sure there is nothing in the way and if there is changes the current radius
        RaycastHit hit = new RaycastHit();
        if(Physics.Raycast(transform.position, (CameraHolder.transform.position - transform.position).normalized, out hit, maxRadius))
            if(hit.collider != null && hit.distance >= minRadius)
                currentRadius = hit.distance;

        //Creates a circle around the camera so that it follows correctly
        Vector3 newPos = CameraHolder.transform.localPosition;

        //Calculations
        float theta = Mathf.Clamp(Mathf.Atan((newPos.y - (ver * TiltSensitivity)) / -newPos.z), -0.7f, 1.5f);
        newPos.z = -currentRadius * Mathf.Cos(theta);
        newPos.y = currentRadius * Mathf.Sin(theta);

        //Sets the positions and fixes the Child position
        CameraHolder.transform.localPosition = newPos;
        CameraHolder.transform.GetChild(0).transform.localPosition = Vector3.zero;

        //Looks at the player
        CameraHolder.transform.LookAt(target.position + new Vector3(0, Height, 0) + (target.transform.forward * 1.3f), transform.up);
    }

    //Builds itself if it's missing something
    void SelfCheckUp() {
        if(transform.Find("CameraHolder") == null) {
            CameraHolder = new GameObject("CameraHolder");
            CameraHolder.transform.parent = transform;
            CameraHolder.transform.localPosition = (target.transform.forward * -Distance) + new Vector3(0, Height, 0);
        }
        if(CameraHolder.transform.Find("Main Camera") == null) {
            Camera.main.transform.parent = CameraHolder.transform;
            Camera.main.transform.localPosition = new Vector3(0, 0, 0);
            Camera.main.transform.rotation = Quaternion.identity;
        }
    }
}