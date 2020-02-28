using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour{

    public List<GameObject> Screens = new List<GameObject>();

    //Variables
    private int _state;

    private void Start() {
        UpdateStateMachine();
    }

    //Cycles through the States
    private void UpdateStateMachine() {
        for(int i = 0; i < Screens.Count; i++) {
            Screens[i].SetActive(i == _state);
        }
    }

    public void UpdateStates(int state) {
        _state = state;
        UpdateStateMachine();
    }

    //Exits the Game
    public void QuitGame() {
        Application.Quit();
    }

    //Loads the Game
    public void StartGame() {
        SceneManager.LoadScene("Scene1");
    }

    //Starts Over
    public void NewGame() {
        GameManager.Manager.NewGame = true;
        SceneManager.LoadScene("Scene1");
    }

}
