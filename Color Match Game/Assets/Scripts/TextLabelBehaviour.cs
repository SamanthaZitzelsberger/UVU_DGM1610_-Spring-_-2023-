using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Text))]
public class TextLabelBehaviour : MonoBehaviour
{
    public Text label;
    public FloatData dataObj;
    public UnityEvent startEvent;

    private void Start()
    {
        label = GetComponent<Text>();
        startEvent.Invoke();
    }

    public virtual void UpdateLabel(FloatData obj)
    {
        Debug.Log("This is update label float");
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
        //dataObj.value.ToString(CultureInfo.InvariantCulture);
    }

    public virtual void UpdateLabel(IntData obj)
    {
        Debug.Log("This is upadte label int");
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
    public virtual void CompareLabel (IntData obj)
    {
        int tmp = Convert.ToInt16(label.text);
        Debug.Log(label.text);
        Debug.Log(tmp);
        Debug.Log(obj.value);
        if(tmp < obj.value)
        {
            label.text = obj.value.ToString(CultureInfo.InvariantCulture);
        }
    }
}
