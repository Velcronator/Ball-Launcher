using UnityEngine;
using UnityEngine.InputSystem;
public class BallHandler : MonoBehaviour
{
    Vector2 _touchPosition;
    // Update is called once per frame
    void Update()
    {
        if (!Touchscreen.current.primaryTouch.press.isPressed) { return; }
        _touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();

        Debug.Log(_touchPosition.ToString());
    }
}
