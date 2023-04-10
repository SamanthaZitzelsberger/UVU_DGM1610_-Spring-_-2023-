using UnityEngine;
using System.Collections;

public class destoryother : MonoBehaviour
{
    public GameObject other;

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Destroy(other);
        }
    }
}
