using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerStatManager))]
public class Movement : MonoBehaviour{

    //References
    private PlayerStatManager _stats;
    private Rigidbody _rb;

    private void Awake() {
        _stats = GetComponent<PlayerStatManager>();
        _rb = GetComponent<Rigidbody>();
        _stats.SetBase();
    }

    void Update()
    {
        if(_stats.CanMove) {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            PlayerMovement(horizontal, vertical);
        }

    }

    //Controls the player
    private void PlayerMovement(float hor, float ver){
        //Moves
        Vector3 newDirection = ((transform.forward * ver) + (transform.right * hor)).normalized;
        _rb.velocity = new Vector3(newDirection.x * _stats.Speed, _rb.velocity.y, newDirection.z * _stats.Speed);

        //Jumps
        if(Input.GetButton("Jump") && CheckGrounded()) {
            _rb.velocity = new Vector3(_rb.velocity.x, _stats.Jump, _rb.velocity.z);
        }
    }

    //Checks to make sure the player is on the ground
    private bool CheckGrounded() {
        Vector3 center = transform.position + GetComponent<CapsuleCollider>().center - new Vector3(0, (GetComponent<CapsuleCollider>().height / 2) + 0.1f, 0);
        return Physics.Raycast(center, Vector3.down, _stats.GroundRayLength, _stats.GroundMask); ;
    }
}
