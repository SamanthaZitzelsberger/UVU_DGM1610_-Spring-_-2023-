using System;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;
    
    public void SetValue(int num)
    {
        value = num;
    }

    public void CompareValue(IntData obj)
    {
        Debug.Log("This is int data Compare" + obj.value + " " +value);
        if (value >= obj.value)
        {

        }
        else
        {
            value = obj.value;
        }

    }

    public void SetValue(IntData obj)
    {
        Debug.Log("int datd set value" + obj.value);
        value = obj.value;
    }
    
    public void UpdateValue(int num)
    {
        Debug.Log("int data update vlaue plus num" + num);
        value += num;
    }
}
