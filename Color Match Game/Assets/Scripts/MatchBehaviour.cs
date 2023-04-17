using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
   public ID idObj;
   public UnityEvent matchEvent, noMatchEvent;

   private void OnTriggerEnter(Collider other)
   {
       var tempObj = other.GetComponent<IDContainerBehaviour>();
       if (tempObj == null) 
            return;

        var otherID = tempObj.idObj;
        if (otherID == idObj)
        {
            //Debug.Log("Matched");
           matchEvent.Invoke();
        }
        else
        {
            //Debug.Log("No Match");
            noMatchEvent.Invoke();
        }
   }
}
