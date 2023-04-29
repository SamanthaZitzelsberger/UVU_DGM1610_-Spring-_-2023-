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
        Debug.Log("This is int data Compare" + obj.value);
        if (value >= obj.value)
        {

        }
        else
        {
            value = obj.value;
        }
        Debug.Log(value);
    }

    public void SetValue(IntData obj)
    {
        value = obj.value;
    }
    
    public void UpdateValue(int num)
    {
        value += num;
    }
}
