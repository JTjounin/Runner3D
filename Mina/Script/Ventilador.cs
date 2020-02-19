using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventilador : MonoBehaviour
{
    public bool inverter;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!inverter)
        {
            transform.Rotate(new Vector3(0f, 0f, 0.5f));
        }
        else if (inverter)
        {
            transform.Rotate(new Vector3(0f, 0f, -0.5f));
        }

    }
}
