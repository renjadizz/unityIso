using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseClickSender : MonoBehaviour
{

    public delegate void MouseClickDelegate(Vector2 mousePos);
    public event MouseClickDelegate MouseClickLeftEvent;
    public event MouseClickDelegate MouseClickRightEvent;

    MouseInput mouseInput;

    private void Awake()
    {
        mouseInput = new MouseInput();
    }
    private void OnEnable()
    {
        mouseInput.Enable();
    }
    private void OnDisable()
    {
        mouseInput.Disable();
    }

    void Start()
    {
        mouseInput.Mouse.MouseClickLeft.performed += _ => MouseClickLeft();
        mouseInput.Mouse.MouseClickRight.performed += _ => MouseClickRight();
    }

     
    private void MouseClickLeft()
    {
        Vector2 mousePosition = GetMousePosition();
        MouseClickLeftEvent?.Invoke(mousePosition);
    }
    private void MouseClickRight()
    {
        Vector2 mousePosition = GetMousePosition();
        MouseClickRightEvent?.Invoke(mousePosition);
    }

    Vector2 GetMousePosition()
    {
        Vector2 mousePosition = mouseInput.Mouse.MousePosition.ReadValue<Vector2>();
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        return mousePosition;
    }
}
