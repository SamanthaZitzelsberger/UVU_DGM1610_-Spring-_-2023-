using UnityEngine;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Dualaxisemaple : MonoBehaviour
{
    public Text horizontalVauleDisplayText;
    public Text verticalVauleDisplayText;
    public float hRange;
    public float vRange;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = v * vRange;

        transform.positions = new Vector3(xPos, 0, vPos);
        horizontalValueDisplayText.text = h.ToString("F2");
        verticalValueDisplayText.text = v.ToString("F2");    
    }
}
