using UnityEngine;
using System.Collections;

public class RocketDestruction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1.5f);
    }
}
