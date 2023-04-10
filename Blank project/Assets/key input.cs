using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class keyinput : MonoBehaviour
{
    public Image graphic;
    public Sprite standard;
    public Sprite downgfx;
    public Sprite upgfx;
    public Text boolDisplay1;
    public Text boolDisplay2;
    public Text boolDisplay3;

    void Start()
    {
        graphic.sprite = standard;    
    }

    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

        if(down)
        {
            graphic.sprite = downgfx;
        }
        else if (held)
        {
            graphic.sprite = heldgfx;
        }
        else if (Up)
        {
            graphic.sprite = upgfx;
        }
        else 
        {
            graphic.sprite = standard;    
        }

        boolDisplay1.text = " " + down;
        boolDisplay2.text = " " + held;
        boolDisplay3.text = " " + held;
    }   
}
