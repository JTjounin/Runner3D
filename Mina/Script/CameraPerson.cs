using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPerson : MonoBehaviour
{
    public GameObject target;
    public float moveSpeed;
    private Vector3 offset;
    // Use this for initialization
    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, Time.deltaTime * moveSpeed);
        }
    }
}
