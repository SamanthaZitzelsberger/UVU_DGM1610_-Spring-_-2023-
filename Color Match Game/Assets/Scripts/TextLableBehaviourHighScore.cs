using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Text))]
public class TextLabelBehaviourHighScore : TextLabelBehaviour
{

    public void UpdateLabel(FloatData obj)
    {
        if(FloatData(label.text) < obj.value)
        {
            label.text = obj.value.ToString(CultureInfo.InvariantCulture);
        }
        //dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}

