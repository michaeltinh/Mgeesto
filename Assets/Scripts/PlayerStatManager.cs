using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStatManager : MonoBehaviour {

    [Header("Movement")]
    public float Speed;
    public float Shoot;
    public float Defense;
    public float Dribble;
    public float Jump;

    [Header("Base Stats")]
    public float BaseSpeed;
    public float BaseShoot;
    public float BaseDefense;
    public float BaseDribble;
    public float BaseJump;

    [Header("Max Stats")]
    public float SpeedMax;
    public float ShootMax;
    public float DefenseMax;
    public float DribbleMax;
    public float JumpMax;

    //Misc
    [Header("Misc.")]
    public bool CanMove;
    public float GroundRayLength = 0.3f;
    public LayerMask GroundMask;

    [Header("Money")]
    public float Money;
    public float MoneyCap;

    //Sets everything to base if the player is starting over
    public void SetBase() {
        Speed = BaseSpeed;
        Shoot = BaseShoot;
        Defense = BaseDefense;
        Dribble = BaseDribble;
        Jump = BaseJump;
        Money = 0;
    }

    //Adds Money
    public void AddMoney(int amount) {
        if(Money + amount > MoneyCap) {
            Money = MoneyCap;
            return;
        }

        Money += amount;
    }

    //Removes and requests money
    public bool RemoveMoney(int amount) {
        if(amount <= Money) {
            Money -= amount;
            return true;
        }
        return false;

    }
}

   
