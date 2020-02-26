using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject optionsMenu;
    public  bool MenuOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenuOpen = true;
            optionsMenu.gameObject.SetActive(!optionsMenu.gameObject.activeSelf);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }

        if (MenuOpen == false)
        {
            MenuOpen = false;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Debug.Log("Hi");

        }
        


    }
}
