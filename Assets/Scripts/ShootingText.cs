using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootingText : MonoBehaviour
{
    public Text currentShoot;

    // Start is called before the first frame update
    void Start()
    {

        currentShoot = GameObject.Find("ShootingAtt").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

        currentShoot.text = GameObject.Find("Player").GetComponent<PlayerStatManager>().currentDefense.ToString();
    }
}
