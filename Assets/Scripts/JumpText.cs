using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JumpText : MonoBehaviour
{
  
    public Text currentJump;
    // Start is called before the first frame update
    void Start()
    {
        currentJump = GameObject.Find("JumpAtt").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        currentJump.text = GameObject.Find("Player").GetComponent<PlayerStatManager>().currentJump.ToString();

    }
}

