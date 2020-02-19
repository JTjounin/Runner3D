using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Transform posicaoInicial;
    public Transform posA;
    public Transform posB;
    public Transform posC;


    public float speed;

    private float startTime; // hora de inicio do movimento
    private float journeyLength; // distancia da jornada
    public Transform Objeto; // objeto a ser movido

    private int idMovimento;

    // Use this for initialization
    void Start()
    {
        Objeto.position = posicaoInicial.position; // Coloca o objeto na posiçao inicial
        PosiçãoA();


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float dist = (Time.time - startTime) * speed;
        float journey = dist / journeyLength;


        switch (idMovimento)
        {
            // A para B
            case 1:
                Objeto.position = Vector3.Lerp(posA.position, posB.position, journey);
                if (Objeto.position == posB.position) { PosiçãoB(); }
                break;

            // B para C
            case 2:
                Objeto.position = Vector3.Lerp(posB.position, posC.position, journey);
                if (Objeto.position == posC.position) { PosiçãoA(); }
                break;



        }

    }


    // Posição A
    void PosiçãoA() // Quando Está Em B
    {
        int rand = Random.Range(0, 1); // O Resultado Sempre Será de 0 ou 1
        if (rand == 0)
        {
            idMovimento = 1;
        }



        startTime = Time.time; // Armazena o horario inicial do movimento
        journeyLength = Vector3.Distance(posA.position, posB.position); // calcula a distancia entre o ponto A e o ponto B

    }


    // Posição B
    void PosiçãoB() // Quando Está Em A
    {
        int rand = Random.Range(0, 1); // O Resultado Sempre Será de 0 ou 1
        if (rand == 0)
        {
            idMovimento = 2;
        }



        startTime = Time.time; // Armazena o horario inicial do movimento
        journeyLength = Vector3.Distance(posB.position, posC.position); // calcula a distancia entre o ponto A e o ponto B

    }


    // Posição C
    void PosiçãoC() // Quando Está Em C
    {
        posC = posA;
    }






}

