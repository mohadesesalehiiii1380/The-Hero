using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Controler : MonoBehaviour
{
   
   public Text highScoreText;
   public Text scoreText;
   public int score;
   public int highScore;
   public Score_Manager score_manager;
   public GameObject gamePausePanel;
   public GameObject gamePauseButton;
   

    void Start()
    {
        gamePausePanel.SetActive(false);
        gamePauseButton.SetActive(true);
    }


    void Update()
    {
        highScore=PlayerPrefs.GetInt("high_score");
        score=score_manager.score;

        highScoreText.text="High Score: " + highScore.ToString();
        scoreText.text="Your Score: " + score.ToString();
    }

    public void Restart(){
        SceneManager.LoadScene("Game");
    }
    
    public void PauseGame(){
     Time.timeScale=0;
    gamePausePanel.SetActive(true);
    gamePauseButton.SetActive(false);
    }
    public void ResumeGame(){
     Time.timeScale=1;
     gamePausePanel.SetActive(false);
     gamePauseButton.SetActive(true);
    }




}
