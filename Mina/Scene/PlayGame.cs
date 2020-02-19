using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : MonoBehaviour
{
    public FasesProgressivas fasesPro;
    // Use this for initialization
    public void GamePlay()
    {
        fasesPro.NextScene();
    }

}
