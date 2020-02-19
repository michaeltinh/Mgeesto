using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySystem : MonoBehaviour
{
    [SerializeField] public int money;

    public void AddMoney(int amount)
    {
        money += amount;
    }

    public void RemoveMoney(int amount)
    {
        if (amount <= money)
        {
            money -= amount;
        }
        else
        {
            Debug.Log("Broke niba");
        }

    }
    public bool RequestMoney(int amount)
    {
        if (amount <= money)
        {
            return true;
        }
        return false;
    }
}
