using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStatManager : MonoBehaviour
{
    public float currentSpeed;
    public float currentMP;
    public float currentShoot;
    public float currentDefense;
    public float currentMagic;
    public float baseSpeed;
    public float baseMP;
    public float baseShoot;
    public float baseDefense;
    public float baseMagic;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatManager>().currentShoot = Stats_Managaer.instance.OverworldAttack;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatManager>().currentDefense = Stats_Managaer.instance.OverworldDefense;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatManager>().currentSpeed = Stats_Managaer.instance.OverworldMagic;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatManager>().baseShoot = Stats_Managaer.instance.BaseOverworldAttack;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatManager>().baseDefense = Stats_Managaer.instance.BaseOverworldDefense;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatManager>().baseSpeed = Stats_Managaer.instance.BaseOverworldMagic;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
