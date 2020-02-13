using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stats_Managaer : MonoBehaviour
{
    //static
    public static Stats_Managaer get;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
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


    //Save Data Betweeen Scenes
    public float currentSpeed;
    public float currentShoot;
    public float currentDefense;
    public float currentMagic;
    public float baseSpeed;
    public float baseShoot;
    public float baseDefense;
    public float currentDribble;
    public float baseDribble;

   

    }

