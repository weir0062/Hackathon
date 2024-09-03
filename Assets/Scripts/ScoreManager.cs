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
    public bool GameOver = false;

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

        if(lives > 0) 
        {
            LoseText.gameObject.SetActive(false);
            GameOver = false;
        }
        if(lives <= 0)
        {
            LoseText.gameObject.SetActive(true);
            GameOver = true;

        }


        if(Input.GetKeyUp(KeyCode.R)) 
        {
            Restart();
        }
    }



    void Restart()
    {
        lives = 3;
        score = 0;
        int thisScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(thisScene);
    }
}
