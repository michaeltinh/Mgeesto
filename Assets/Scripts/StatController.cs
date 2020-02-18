using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatController : MonoBehaviour
{

    public float increase = 1f;
    PlayerStatManager statscript;
    // Start is called before the first frame update
    void Start()
    {
       statscript = GetComponent<PlayerStatManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void ShootingIncrease()
    {
        statscript.currentShoot++;
        
    }
}
