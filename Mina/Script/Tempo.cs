using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tempo : MonoBehaviour
{
    public float tempo;
    public float timeStart = 0;
    public Text textBox;

    public ScoreRecord recorde;
    public Tempo time;
    public GameObject proximaPartida;


    // Use this for initialization
    void Start()
    {
        textBox.text = timeStart.ToString();
        timeStart = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeStart < tempo)
        {
            timeStart += Time.deltaTime;
            textBox.text = Mathf.Round(timeStart).ToString();
        }

        else if (timeStart > tempo)
        {
            recorde.score = time.timeStart;
            proximaPartida.SetActive(true);
            recorde.StopScore();
            //  recorde.pegarNome();
            // SceneManager.LoadScene("GameObject");
        }
    }




}
