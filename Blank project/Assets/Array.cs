using UnityEngine;
using System.Collections;

public class Array : MonoBehaviour
{
    public GameObject[] players;

    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

        for(int i = 0; i < players.Length; i++)
        {
            Debig.Log("Playerr Number "+i+" is named "+players[i].name);
        }    
    }
}
