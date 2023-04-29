using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Text))]
public class TextLabelBehaviourHighScore : TextLabelBehaviour
{
    public Text label;
    public FloatData dataObj;

    public void UpdateLabel(FloatData obj)
    {
        if
        {

        }
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
        //dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}

