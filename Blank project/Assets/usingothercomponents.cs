using UnityEngine;
using System.Collections;

public class usingothercomponents : MonoBehaviour
{
    public GameObject other GameObject;

    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxcol;

    void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComonent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }

    void Start()
    {
        boxCol.size = new Vector3(3,3,3);
        Debug.Log("The player's score is " + anotherScript.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " times");
    }
}
