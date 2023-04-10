using UnityEngine;
using System.Collections;

public class foreachloop : MonoBehaviour
{
    void Start()
    {
        string[] string = new string[3];

        string[0] = "First string";
        string[1] = "Second string";
        string[2] = "Third string";

        foreach(string item in strings)
        {
            print(item);
        } 
    }
}
