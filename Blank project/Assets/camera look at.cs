using UnityEngine;
using System.Collections;

public class cameralookat : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        transform.LookAt(target);
    }
}
