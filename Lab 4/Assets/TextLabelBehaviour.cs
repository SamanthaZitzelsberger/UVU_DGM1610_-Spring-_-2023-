using System.Globalization;
using UnityEngine;
using Unityengine.UI;

[RequireComponet(typeof(Text))]
public class NewBehaviourScript : MonoBehaviour
{
    public Text label;
    public Floatdata dataObj;

    private void Start()
    {
        label = GetComponent<Text>();
        label.text = dataObj.vaule.ToString(CultureInfo.InvariantCulture);
    }
}
