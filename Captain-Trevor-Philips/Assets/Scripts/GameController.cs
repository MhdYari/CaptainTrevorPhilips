using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text highScoreText;
    public Text scoreText; 
    public int score;
    public int highScore;
    public ScoreManager scoremanager;
    public GameObject pause_Panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highScore = PlayerPrefs.GetInt("Highscore");
        score = scoremanager.score;
        highScoreText.text = "High Score: " + highScore.ToString();
        scoreText.text = "Your Score: " + score.ToString(); 
    }

    public void Restart()
    {
        SceneManager.LoadScene("CaptainPhilips");
    }

    public void Pause()
    {
        Time.timeScale = 0;
        pause_Panel.SetActive(true);
    }

    public void Rusume()
    {
        Time.timeScale = 1;
        pause_Panel.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
