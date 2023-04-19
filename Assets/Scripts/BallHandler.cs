using UnityEngine;
using UnityEngine.InputSystem;
public class BallHandler : MonoBehaviour
{
    private Camera m_Camera;

    private void Start()
    {
        m_Camera = Camera.main;
    }

    Vector2 _touchPosition;
    // Update is called once per frame
    void Update()
    {
        if (!Touchscreen.current.primaryTouch.press.isPressed) { return; }
        _touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();

        Vector3 worldPosition = m_Camera.ScreenToWorldPoint(_touchPosition);

        Debug.Log(worldPosition);
    }
}
