using UnityEngine;
using System.Collections;

public class dowhileloop : MonoBehaviour
{
    void Start()
    {
        bool shouldContinue = false;

        do
        {
            print("Hello World");

        } while (shouldContinue == true);    
    }
}
