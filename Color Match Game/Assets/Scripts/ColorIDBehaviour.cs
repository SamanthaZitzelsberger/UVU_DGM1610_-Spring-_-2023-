using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIDBehaviour : IDContainerBehaviour
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        colorIDDataListObj.SetCurrentColorRandomly;
        idObj = colorIDDataListObj.currentColor;
    }
}
