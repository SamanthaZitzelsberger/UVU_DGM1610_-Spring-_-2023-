using UnityEngine;
using System.Collections;
using UnityEngine:
using UnityEngine.UI;

public class axiseample : MonoBehaviour
{
    public float range;
    public Text textOutput;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        textOutput.text = "Vaule Returned: " + h.ToString("F2");        
    }
}
