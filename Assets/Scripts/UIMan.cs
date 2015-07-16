using UnityEngine;
using System.Collections;

public class UIMan : MonoBehaviour {
    public GameObject MainMenu;
    public GameObject DiedMenu;
    public GameObject HUD;
    public HighScore highScoreText;
    public bool GameRunning = false;


    public void StartGame()
    {
        GameMan.GameManager.soundManager.Main.Stop();
        GameRunning = true;
        MainMenu.SetActive(false);
        GameMan.GameManager.StartGame();
    }

    public void Retry()
    {
        GameRunning = true;
        DiedMenu.SetActive(false);
        GameMan.GameManager.Retry();
    }
    public void Die(){
        GameRunning = false;
        DiedMenu.SetActive(true);
        highScoreText.UpdateHighScore();
        GameMan.GameManager.Die();
    }
    void Update()
    {
        if (GameMan.GameManager.Died&&!DiedMenu.activeSelf)
            Die();
        
        if (GameMan.GameManager.InputManager.Jump)
        {
            if(DiedMenu.activeSelf)
            {
                Retry();
            }
            else if (MainMenu.activeSelf)
            {
                StartGame();
            }
            
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            if (DiedMenu.activeSelf)
            {
                Retry();
            }
            else if (MainMenu.activeSelf)
            {
                Application.Quit();
            }
            else
            {
                Application.LoadLevel(0);
            }
        }
    }
}
