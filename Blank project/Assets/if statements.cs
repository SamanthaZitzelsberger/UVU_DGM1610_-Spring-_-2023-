using UnityEngine;
using System.Collections;

public class ifstatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest()
    {
        // If the coffee's temperature is greater than the hottest drinking temperature . . .
        if(coffeeTemperature > hotLimitTemperature)
        {
            // . . . do this.
            print("Coffee is too hot");
        }
        else if(coffeeTemperature < coldLimitTemperature)
        {
            // . . .do this.
            print("Coffee is too cold.");
        }
        //if it is neither of those then . . .
        else
        {
            // . . .do this.
            print("Coffee is just right");
        }
    }
}
