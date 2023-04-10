using UnityEngine;
using System.Collections;

public class DataTypeScript : MonoBehaviour
{
    
    void Start()
    {
        //Vaule type variable
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 0,);

        //Refereance type variable
        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);    
    }
}
