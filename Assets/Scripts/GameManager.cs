using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //References
    public static GameManager Manager;

    public GameObject Player;
    public PlayerStatManager PlayerStats;
    public bool NewGame;

    //Private References
    private SaveData _saveData;
    private Scene prevScene;

    private void Awake() {
        //Creates a singleton
        if(Manager == null) {
            Manager = this;
            DontDestroyOnLoad(gameObject);
        } else
            Destroy(gameObject);

        //Loads References
        _saveData = GetComponent<SaveData>();
        prevScene = SceneManager.GetActiveScene();
    }

    private void Update() {
        if(SceneManager.GetActiveScene() != prevScene) {
            ReloadScene();
            prevScene = SceneManager.GetActiveScene();
        }
    }

    //Should launch at the beginning of every scene
    public void ReloadScene() {
        if(GameObject.FindGameObjectWithTag("Player") != null) {
            Player = GameObject.FindGameObjectWithTag("Player");
            PlayerStats = Player.GetComponent<PlayerStatManager>();
            if(NewGame) {
                PlayerStats.SetBase();
                _saveData.SaveStats(PlayerStats);
                NewGame = false;
            } else {
                _saveData.LoadStats(ref PlayerStats);
            }
        }
    }

    //Saves the player stats
    public void Save() {
        _saveData.SaveStats(PlayerStats);
    }
}
