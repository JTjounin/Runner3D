using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TempoPositivo : MonoBehaviour
{
    public float timeStart;
    public Text textBox;
    public GameObject canvas;
    public GameObject canvasPositivo;

    public UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl scriptPessoa;
    public bool Desativado;

    // Use this for initialization
    void Start()
    {
        textBox.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (timeStart > 0)
        {
            timeStart -= Time.deltaTime;
            textBox.text = Mathf.Round(timeStart).ToString();
        }

        else if (timeStart < 0)
        {
            canvas.SetActive(true);
            canvasPositivo.SetActive(false);
            Desativado = true;
            scriptPessoa.enabled = true;
        }

        if (canvasPositivo == isActiveAndEnabled)
        {
            scriptPessoa.enabled = false;
        }
    }
}
