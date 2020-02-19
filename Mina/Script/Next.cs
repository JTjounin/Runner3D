using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public ScoreRecord recorde;
    public Tempo time;
    public GameObject proximaPartida;

    public UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl scriptPessoa;
    public bool Desativado;

    // Use this for initialization
    void Start()
    {
        proximaPartida.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            // SceneManager.LoadScene("Mina");
            recorde.score = time.timeStart;

            Desativado = true;
            proximaPartida.SetActive(true);

            recorde.StopScore();

        }

    }




}
