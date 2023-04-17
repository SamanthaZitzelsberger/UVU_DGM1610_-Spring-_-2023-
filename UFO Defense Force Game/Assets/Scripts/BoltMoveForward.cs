using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltMoveForward : MonoBehaviour
{
    public float speed = 100.0f;

    // Update is called once per frame
    void Update()
    {
        //Move GameOject forward
        transform.Translate(Vector3.up * Time.deltaTime * speed);    
    }
}
