using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    //References
    public GameObject Options;
    public GameObject Upgrade;

    //Variables
    private int _state;

    private void Awake() {
        _state = 0;
        StateManager();
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape) && _state == 0) {
            _state = 1;
            StateManager();
        } else if(Input.GetKeyDown(KeyCode.Escape)) {
            _state = 0;
            StateManager();
        }
    }

    private void StateManager() {
        //Locks Movement
        int isActive = 0;

        //Not opened
        Cursor.lockState = _state == isActive ? CursorLockMode.Locked : CursorLockMode.None ;
        Cursor.visible = _state != isActive;

        //Paused
        Options.SetActive(_state == ++isActive);

        //Upgrade
        Upgrade.SetActive(_state == ++isActive);

    }

    //Switches which state is active
    public void SwitchState(int newState) {
        _state = newState;
        StateManager();
    }

    //Returns to Main Menu
    public void ReturnToMenu() {
        SceneManager.LoadScene("Main Menu");
    }

}
