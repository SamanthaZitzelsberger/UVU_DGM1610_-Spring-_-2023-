using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;

    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    void Update()
    {
        if (Time.timeScale == 0)
            gameOverText.gameObject.SetActive(true);
        else
            gameOverText.gameObject.SetActive(false);
    }
}
