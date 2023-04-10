using UnityEngine;
using System.Collections;

public class destorycomponent : MonoBehaviour
{
    void Update()
    {
        if(Input,GetKey(KeyCode.Space))
        {
            Destroy(GetComponent<MeshRenderer());
        }    
    }
}
