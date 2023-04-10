using UnityEngine;
using System.Collections;

public class Mouseclick : MonoBehaviour
{
    private Rigidbody rb;

    private viod Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        rb.AddForce(-transform.foward * 500f);
        rb.useGravity = true;
    }
}
