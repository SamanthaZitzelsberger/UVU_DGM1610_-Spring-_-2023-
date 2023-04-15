using UnityEngine;
using UnityEngine.UIElements;

// Add KeyboardEventTest to a GameObject with a valid UIDocument.
// When the user presses a key, it will print the keyboard event properties to the console.
[RequireComponent(typeof(UIDocument))]
public class KeyboardEventTest : MonoBehaviour
{
    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        root.Add(new Label("Press any key to see the keyDown properties"));
        root.Add(new TextField());
        root.Q<TextField>().Focus();
        root.RegisterCallback<KeyDownEvent>(OnKeyDown, TrickleDown.TrickleDown);
    }
    void OnKeyDown(KeyDownEvent ev)
    {
        Debug.Log("KeyDown:" + ev.keyCode);
        Debug.Log("KeyDown:" + ev.character);
        Debug.Log("KeyDown:" + ev.modifiers);
    }
}
