using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{


    public GameObject MenuPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void StartGame()
    {
        MenuPanel.SetActive(false);
    }


    public void ReturnToMenu()
    {
        MenuPanel.SetActive(true);
    }


    public void ExitGame()
    {
        Application.Quit();
    }



}
