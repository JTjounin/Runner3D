using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FasesProgressivas : MonoBehaviour
{
    public static FasesProgressivas Instance { get; private set; }

    public List<string> Cenas = new List<string>();
    // Use this for initialization
    string key = "Cena";
    public int i;
    private void Awake()
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
    }
    // Update is called once per frame

    void Start()
    {
        i = PlayerPrefs.GetInt(key, 0);

        string Cena = SceneManager.GetActiveScene().name;


        if (Cena != "TelaPlay")
        {
            if (PlayerPrefs.GetInt(key, 0) >= 0)
            {
                PlayerPrefs.SetInt(key, i + 1);
            }
        }
    }

    void Update()
    {
        i = PlayerPrefs.GetInt(key, 0);

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (PlayerPrefs.GetInt(key, 0) >= 0)
            {
                PlayerPrefs.SetInt(key, 0);
            }
        }

        print(PlayerPrefs.GetInt(key, 0));

        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene(Cenas[i], LoadSceneMode.Single);
        }

    }

    public void NextScene()
    {
        SceneManager.LoadScene(Cenas[i], LoadSceneMode.Single);
    }


    public void menU()
    {
        SceneManager.LoadScene("TelaPlay");
    }

}

