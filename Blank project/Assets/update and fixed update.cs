using UnityEngine;
using System.Collections;

public class updateandfixedupdate : MonoBehaviour
{
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }

    void Update()
    {
        Debug.Log("Update Time :" + Time.deltaTime);    
    }
}
