using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FaseAleatoria : MonoBehaviour
{
    public static FaseAleatoria Instance { get; private set; }
    /* private void Awake()
     {
         if (Instance == null)
         {
             Instance = this;
             DontDestroyOnLoad(gameObject);
         }
         else
         {
             Destroy(gameObject);
         }
     }*/


    public void First()
    {
        SceneManager.LoadScene("Mina");

    }


    public void Second()
    {
        SceneManager.LoadScene("Fase2");

    }


    public void Third()
    {
        SceneManager.LoadScene("Fase3");

    }



    public void Aleatoria()
    {
        int rand = Random.Range(0, 3);
        if (rand == 0)
        {
            First();
        }
        else if (rand == 1)
        {
            Second();
        }

        else if (rand == 2)
        {
            Third();
        }
    }
}
