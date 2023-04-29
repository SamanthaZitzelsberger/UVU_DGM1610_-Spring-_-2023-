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

    public void UpdateLabel(FloatData obj)
    {
        Debug.Log("This is update label float");
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
        //dataObj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateLabel(IntData obj)
    {
        Debug.Log("This is upadte label int" + obj.value + gameObject.name);
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
    public void CompareLabel (IntData obj)
    {
        Debug.Log("this is compare label");
        int tmp = Convert.ToInt16(label.text);
        Debug.Log(label.text);
        Debug.Log(tmp);
        Debug.Log(obj.value);
        if(tmp < obj.value)
        {
            label.text = obj.value.ToString(CultureInfo.InvariantCulture);
        }
    }

    public void Reset()
    {
        label.text = "0";
    }
}
