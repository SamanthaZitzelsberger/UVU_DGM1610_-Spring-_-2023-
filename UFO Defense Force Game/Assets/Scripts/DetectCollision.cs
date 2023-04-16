using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    public int scoreToGive;
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        scoreManager.IncreaseScore(scoreToGive);
        Destroy(other.gameObject);
    }
}
