using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public int highScore;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Score());
        StartCoroutine(Reload());
        highScore = PlayerPrefs.GetInt("HighScore", highScore);
    }

    // Update is called once per frame
    void Update()
    { 
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", 0);
        }
    }
     IEnumerator Score()
        {
            while(true)
            {
                yield return new WaitForSeconds(3);
                score += 10;
            }
        }

        IEnumerator Reload()
        {            
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene("");
        }
}
