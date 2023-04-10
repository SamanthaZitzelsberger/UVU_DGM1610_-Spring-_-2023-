using UnityEngine;
using System.Collections;

public class scopeandaccessmodifiers : MonoBehaviour
{
    public int alpha = 5;

    private int beta = 0;
    private int gamma = 5;

    private AnotherClass myOtherClass;

    void Start()
    {
        alpha = 29;

        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOther.apples);   
    }

    void Example (int pens, int carayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }

    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha)    
    }
}
