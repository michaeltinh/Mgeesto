using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStatManager : MonoBehaviour
{
    public float currentSpeed;
    public float currentShoot;
    public float currentDefense;
    public float baseSpeed;
    public float baseShoot;
    public float baseDefense;
    public float currentDribble;
    public float baseDribble;

    // Start is called before the first frame update
    void Start()
    {

        GameObject.Find("Player").GetComponent<PlayerStatManager>().currentShoot = Stats_Managaer.get.currentShoot;
        GameObject.Find("Player").GetComponent<PlayerStatManager>().currentDefense = Stats_Managaer.get.currentDefense;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatManager>().currentSpeed = Stats_Managaer.get.currentSpeed;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatManager>().currentDribble = Stats_Managaer.get.currentDribble;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatManager>().baseShoot = Stats_Managaer.get.baseShoot;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatManager>().baseDefense = Stats_Managaer.get.baseDefense;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatManager>().baseSpeed = Stats_Managaer.get.baseSpeed;
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatManager>().baseDribble = Stats_Managaer.get.baseDribble;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
