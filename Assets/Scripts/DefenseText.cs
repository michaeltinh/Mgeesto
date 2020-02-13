using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenseText : MonoBehaviour
{
    public Text currentDefense;
    // Start is called before the first frame update
    void Start()
    {
        currentDefense = GameObject.Find("DefenseAtt").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        currentDefense.text = GameObject.Find("Player").GetComponent<PlayerStatManager>().currentDefense.ToString();

    }
}

