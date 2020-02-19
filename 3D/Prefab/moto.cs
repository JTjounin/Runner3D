using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moto : MonoBehaviour
{

    public float moveSpeed = 20.0f;
    public Vector3 pos;
    public float moveX;
    public float moveY;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*  pos = transform.position;
          pos.x += moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
          pos.z += moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
          transform.position = pos; */

        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

    }
}
