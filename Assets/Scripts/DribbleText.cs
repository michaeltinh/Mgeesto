using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DribbleText : MonoBehaviour
{
    public Text currentDribble;
    // Start is called before the first frame update
    void Start()
    {
        currentDribble = GameObject.Find("DribbleAtt").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        currentDribble.text = GameObject.Find("Player").GetComponent<PlayerStatManager>().currentDribble.ToString();

    }
}
