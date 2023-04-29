using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorIDDataList : ScriptableObject
{
    public List<ColorID> colorIDList;

    public ColorID currentColor;
    
    private int num;

    public void SetCurrentColorRandomly()
    {
        //num = colorIDList.Count-1;
        currentColor = colorIDList[Random.Range(0, colorIDList.Count)];
        //Random.Range(0,ufoPrefabs.Length);
    }
}
