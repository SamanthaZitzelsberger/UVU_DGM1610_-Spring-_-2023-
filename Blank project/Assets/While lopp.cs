using UnityEngine;
using System.Collections;

public class Whilelopp : MonoBehaviour
{
    int cupsInTheSink = 4;

    void Start()
    {
        while(cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
        }    
    }
}
