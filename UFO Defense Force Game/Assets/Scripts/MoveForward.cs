using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        //Move GameOject forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);    
    }
}
