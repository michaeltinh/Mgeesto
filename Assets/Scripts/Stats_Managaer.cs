using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stats_Managaer : MonoBehaviour
{
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
            Debug.Log("Insufficent Funds!!!");
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
    public float BattleHP;
    public float BattleMP;
    public float BattleAttack;
    public float BattleDefense;
    public float BattleMagic;
    public float OverworldHP;
    public float OverworldMP;
    public float OverworldAttack;
    public float OverworldDefense;
    public float OverworldMagic;
    public float BaseBattleHP;
    public float BaseBattleMP;
    public float BaseBattleAttack;
    public float BaseBattleDefense;
    public float BaseBattleMagic;
    public float BaseOverworldHP;
    public float BaseOverworldMP;
    public float BaseOverworldAttack;
    public float BaseOverworldDefense;
    public float BaseOverworldMagic;

    //static
    public static Stats_Managaer instance;

    }

