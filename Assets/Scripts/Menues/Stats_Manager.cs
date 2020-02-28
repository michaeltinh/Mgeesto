using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats_Manager : MonoBehaviour
{
    public List<Text> Texts = new List<Text>();
    public List<Image> Progress = new List<Image>();
    public Text MoneyText;
    private bool _free = true;

    private void Start() {
        for(int i = 0; i < Texts.Count; i++)
            Upgrade(i);
        _free = false;
    }

    public void Upgrade(int state) {
        if(_free || (GameManager.Manager.PlayerStats.RemoveMoney(10) && ReturnCurrent(state) < ReturnMax(state))) {
            if(!_free)   UpdateStat(state);

            Texts[state].text = "" + ReturnCurrent(state);
            Progress[state].fillAmount = ReturnCurrent(state) / ReturnMax(state);
            MoneyText.text = GameManager.Manager.PlayerStats.Money.ToString();
        }
    }

    //Updates the selected Stat
    private void UpdateStat(int state) {
        switch(state) {
            case 0:     GameManager.Manager.PlayerStats.Speed += 1;     break;
            case 1:     GameManager.Manager.PlayerStats.Shoot += 1;     break;
            case 2:     GameManager.Manager.PlayerStats.Defense += 1;   break;
            case 3:     GameManager.Manager.PlayerStats.Dribble += 1;   break;
            case 4:     GameManager.Manager.PlayerStats.Jump += 1;      break;
        }

        GameManager.Manager.Save();
    }

    //Returns the Current Stat
    private float ReturnCurrent(int state) {
        switch(state) {
            case 0: return GameManager.Manager.PlayerStats.Speed;
            case 1: return GameManager.Manager.PlayerStats.Shoot;
            case 2: return GameManager.Manager.PlayerStats.Defense;
            case 3: return GameManager.Manager.PlayerStats.Dribble;
            case 4: return GameManager.Manager.PlayerStats.Jump;
        }

        return 0;
    }

    //Returns the Max the Stat could be
    private float ReturnMax(int state) {
        switch(state) {
            case 0: return GameManager.Manager.PlayerStats.SpeedMax;
            case 1: return GameManager.Manager.PlayerStats.ShootMax;
            case 2: return GameManager.Manager.PlayerStats.DefenseMax;
            case 3: return GameManager.Manager.PlayerStats.DribbleMax;
            case 4: return GameManager.Manager.PlayerStats.JumpMax;
        }

        return 0;
    }

}

