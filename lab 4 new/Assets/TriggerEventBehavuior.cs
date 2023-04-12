using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavuior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
