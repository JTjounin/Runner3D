using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class Rascunho : MonoBehaviour
{

    public Text scoreText;            //The score text
    public Text highScoreText;        //The high score text

    public float score;                              //The player's score
    public float highScore = 500f;                          //The high score
    string highScoreKey = "highScore";      //Name of the high score




    void Start()
    {
        highScoreText.text = PlayerPrefs.GetFloat(highScoreKey, 0).ToString();
        highScore = PlayerPrefs.GetFloat(highScoreKey, 0);
    }

    void Update()
    {


        //if the player beats the high score, the high score is set to their score
        if (PlayerPrefs.GetFloat(highScoreKey, 0) > score)
        {
            highScore = score;
        }

        Debug.Log(highScore);
        //Set the GUI to relfect the current score and high score
        scoreText.text = score.ToString();
        highScoreText.text = "HighScore : " + highScore.ToString();
    }


    public void GameOver()
    {
        //Call the save method
        Save();
    }


    public void Initialize()
    {
        //Reset the score and get the high score from the playerprefs

        if (score > PlayerPrefs.GetFloat(highScoreKey, 0))
        {
            PlayerPrefs.GetFloat(highScoreKey, score);
            highScoreText.text = score.ToString();
        }

    }


    public void Save()
    {
        //Save the highscore to the player prefs
        PlayerPrefs.SetFloat(highScoreKey, highScore);
        PlayerPrefs.Save();
        //Re initialize the score

    }
}