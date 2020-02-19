using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatController : MonoBehaviour
{

    public float increase = 1f;
    PlayerStatManager statscript;
    public GameObject Player;
    MoneySystem moneySystem;

    // Start is called before the first frame update
    void Start()
    {
        moneySystem = FindObjectOfType<MoneySystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void ShootingIncrease()
    {
        if (moneySystem.money >= 0.1f)
        {
            Player.GetComponent<PlayerStatManager>().currentShoot++;
            moneySystem.RemoveMoney(10);
        }
    }
    public void SpeedIncrease()
    {
        if (moneySystem.money >= 0.1f)
        {
            Player.GetComponent<PlayerStatManager>().currentSpeed++;
            moneySystem.RemoveMoney(10);
        }
    }
    public void DefenseIncrease()
    {
        if (moneySystem.money >= 0.1f)
        {
            Player.GetComponent<PlayerStatManager>().currentDefense++;
            moneySystem.RemoveMoney(10);
        }
    }
    public void handleIncrease()
    {
        if (moneySystem.money >= 0.1f)
        {
            Player.GetComponent<PlayerStatManager>().currentDribble++;
            moneySystem.RemoveMoney(10);
        }
    }
    public void jumpIncrease()
    {
        if (moneySystem.money >= 0.1f)
        {
            Player.GetComponent<PlayerStatManager>().currentJump++;
            moneySystem.RemoveMoney(10);
        }
    }
    public void moneyIncrease()
    {
        moneySystem.AddMoney(10);
    }

}
