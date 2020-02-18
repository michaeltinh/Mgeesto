using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Money : MonoBehaviour
{
    public Text MoneyValue;

    // Start is called before the first frame update
    void Start()
    {
        //MoneyValue = GameObject.Find("MoneyValue").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        MoneyValue.text = GameObject.Find("Player").GetComponent<PlayerStatManager>().money.ToString();
    }
}