using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour{

    //Saves the player stats
    public void SaveStats(PlayerStatManager stats) {
        PlayerPrefs.SetFloat("SPEED", stats.Speed);
        PlayerPrefs.SetFloat("JUMP", stats.Jump);
        PlayerPrefs.SetFloat("SHOOT", stats.Shoot);
        PlayerPrefs.SetFloat("DEFENSE", stats.Defense);
        PlayerPrefs.SetFloat("DRIBBLE", stats.Dribble);
        PlayerPrefs.SetFloat("MONEY", stats.Money);
    }

    //Loads the player stats
    public void LoadStats(ref PlayerStatManager stats){
        stats.Speed = PlayerPrefs.GetFloat("SPEED", stats.BaseSpeed);
        stats.Jump = PlayerPrefs.GetFloat("JUMP", stats.BaseJump);
        stats.Shoot = PlayerPrefs.GetFloat("SHOOT", stats.BaseShoot);
        stats.Defense = PlayerPrefs.GetFloat("DEFENSE", stats.BaseDefense);
        stats.Dribble = PlayerPrefs.GetFloat("DRIBBLE", stats.BaseDribble);
        stats.Money = PlayerPrefs.GetFloat("MONEY", 0);
    }
}
