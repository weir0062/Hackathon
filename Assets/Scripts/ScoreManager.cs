using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public int lives;
    public Text ScoreText;
    public Text LivesText;
    public Text LoseText;
    public Text WinText;
    public bool GameOver = false;
    public AudioManager Audiomanager;
    public Menu menu;

    Brick[] bricks;
    // Start is called before the first frame update
    void Start()
    {
        bricks = GameObject.FindObjectsOfType<Brick>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = score.ToString();
        LivesText.text = "Lives: " + lives.ToString();

        if(lives > 0 && score < 28) 
        {
            LoseText.gameObject.SetActive(false);
            GameOver = false;
        }
        if(lives <= 0)
        {
            LoseText.gameObject.SetActive(true);
            GameOver = true;
            Audiomanager.PlayLoseSound();

        }

        if(score >= 28)
        {
            WinText.gameObject.SetActive(true);
            GameOver=true;
        }
        else
        {
            WinText.gameObject.SetActive(false);
        }
        if(Input.GetKeyUp(KeyCode.R)) 
        {
            Restart();
        }

        if (Input.GetKeyUp(KeyCode.M))
        {
            ReturnToMenu();
        }
    }



    void Restart()
    {
        lives = 3;
        score = 0;
        int thisScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(thisScene);
        menu.StartGame();
    }

    void ReturnToMenu()
    {
        Restart();
        menu.ReturnToMenu();

    }
}
