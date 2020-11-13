// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputController/HeroController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MouseInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MouseInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""HeroController"",
    ""maps"": [
        {
            ""name"": ""Mouse"",
            ""id"": ""312ada19-5a5f-4e94-b923-a87fc637d6f2"",
            ""actions"": [
                {
                    ""name"": ""MouseClickLeft"",
                    ""type"": ""Button"",
                    ""id"": ""28fd1cb9-5cb8-48fa-8379-4e2d747c68f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""a55fab0d-b7f6-4984-bd7c-c316086be648"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseClickRight"",
                    ""type"": ""Button"",
                    ""id"": ""aff0be8b-12b7-4d61-8f81-a0acc78e21ab"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cc9682c2-282d-4b88-a44d-71b9ad14a9e2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseClickLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9871b56-75bf-4c11-bf81-1d423d25bfdf"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c57a4d1-89d2-498e-b464-6f6d0b9d9fd8"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseClickRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_MouseClickLeft = m_Mouse.FindAction("MouseClickLeft", throwIfNotFound: true);
        m_Mouse_MousePosition = m_Mouse.FindAction("MousePosition", throwIfNotFound: true);
        m_Mouse_MouseClickRight = m_Mouse.FindAction("MouseClickRight", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_MouseClickLeft;
    private readonly InputAction m_Mouse_MousePosition;
    private readonly InputAction m_Mouse_MouseClickRight;
    public struct MouseActions
    {
        private @MouseInput m_Wrapper;
        public MouseActions(@MouseInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseClickLeft => m_Wrapper.m_Mouse_MouseClickLeft;
        public InputAction @MousePosition => m_Wrapper.m_Mouse_MousePosition;
        public InputAction @MouseClickRight => m_Wrapper.m_Mouse_MouseClickRight;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @MouseClickLeft.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseClickLeft;
                @MouseClickLeft.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseClickLeft;
                @MouseClickLeft.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseClickLeft;
                @MousePosition.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMousePosition;
                @MouseClickRight.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseClickRight;
                @MouseClickRight.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseClickRight;
                @MouseClickRight.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseClickRight;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseClickLeft.started += instance.OnMouseClickLeft;
                @MouseClickLeft.performed += instance.OnMouseClickLeft;
                @MouseClickLeft.canceled += instance.OnMouseClickLeft;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @MouseClickRight.started += instance.OnMouseClickRight;
                @MouseClickRight.performed += instance.OnMouseClickRight;
                @MouseClickRight.canceled += instance.OnMouseClickRight;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);
    public interface IMouseActions
    {
        void OnMouseClickLeft(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnMouseClickRight(InputAction.CallbackContext context);
    }
}
