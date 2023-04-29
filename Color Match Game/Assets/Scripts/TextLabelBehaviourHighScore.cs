using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Text))]
public class TextLabelBehaviourHighScore : TextLabelBehaviour
{

    public override void UpdateLabel(FloatData obj)
    {
        float tmp = Convert.ToSingle(label.text);
        if(tmp < obj.value)
        {
            label.text = obj.value.ToString(CultureInfo.InvariantCulture);
        }
        //dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}

