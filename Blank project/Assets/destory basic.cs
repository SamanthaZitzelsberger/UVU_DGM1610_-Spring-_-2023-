using UnityEngine;
using System.Collections;

public class destorybasic : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(gameObject);
        }    
    }
}
