using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class ScoreRecord : MonoBehaviour
{

    public Text scoreText;            //The score text

    public Text firstText;        //The high score text
    public Text secondText;
    public Text thirdText;


    public float score;                              //The player's score
    public float first;                          //The high score
    public float second;
    public float third;

    string highScoreKey = "highScore";      //Name of the high score




    void Start()
    {
        first = PlayerPrefs.GetFloat(highScoreKey, 0);
        second = PlayerPrefs.GetFloat(highScoreKey, 0);
        third = PlayerPrefs.GetFloat(highScoreKey, 0);


        /* firstText.text = PlayerPrefs.GetFloat(highScoreKey, 0).ToString();
         secondText.text = PlayerPrefs.GetFloat(highScoreKey, 0).ToString();
         thirdText.text = PlayerPrefs.GetFloat(highScoreKey, 0).ToString();*/
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.X))
        {
            pegarNome();
        }

    }


    public void StopScore()
    {
        //if the player beats the high score, the high score is set to their score
        if (PlayerPrefs.GetFloat(highScoreKey, 0) > score)
        {
            PlayerPrefs.SetFloat(highScoreKey, score);
        }




        Debug.Log(PlayerPrefs.GetFloat(highScoreKey, 0));
        //Set the GUI to relfect the current score and high score
        scoreText.text = score.ToString();
        // firstText.text = "First : " + (PlayerPrefs.GetFloat(highScoreKey, 0));
        //secondText.text = "Second : " + (PlayerPrefs.GetFloat(highScoreKey, 0));
        //thirdText.text = "Third : " + (PlayerPrefs.GetFloat(highScoreKey, 0));

    }


    /* SCRIPT DA CLASSIFICAÇÃO DO RANK !!!*/

    public ScoreRecord recorde;
    public Tempo time;

    public List<Text> listaTexto = new List<Text>();
    // public Text textPontos;
    // public InputField inputName;
    public float pontos;
    // public string[] result;


    // private float first;


    //public Text firstText;


    public Text[] texto;




    public void pegarNome()
    {
        // result = new string[] { inputName.text };


        if (PlayerPrefs.GetFloat(highScoreKey, 0) > first)
        {
            //first = float.Parse(highScoreText.text);
            firstText.text = PlayerPrefs.GetFloat(highScoreKey, 0).ToString();
        }


        else if (PlayerPrefs.GetFloat(highScoreKey, 0) > second)
        {
            //second = float.Parse(highScoreText.text);
            secondText.text = PlayerPrefs.GetFloat(highScoreKey, 0).ToString();
        }


        else if (PlayerPrefs.GetFloat(highScoreKey, 0) > score)
        {
            // third = float.Parse(highScoreText.text);
            thirdText.text = firstText.text + " pts";
            thirdText.text = "inha";
        }


    }
}