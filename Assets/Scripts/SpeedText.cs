using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedText : MonoBehaviour
{
    public Text currentSpeed;
    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = GameObject.Find("SpeedAtt").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed.text = GameObject.Find("Player").GetComponent<PlayerStatManager>().currentSpeed.ToString();

    }
}

