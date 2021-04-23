// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/Movement.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MovementInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MovementInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Movement"",
    ""maps"": [
        {
            ""name"": ""CameraMove"",
            ""id"": ""5477f4d6-fbf5-4364-a82d-2f84a4a87d6a"",
            ""actions"": [
                {
                    ""name"": ""RotateCamera"",
                    ""type"": ""Value"",
                    ""id"": ""a2fdcc37-7b0e-4a7e-9e0f-09a132496854"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a2a23c03-720b-40be-89b6-3212e9753cfb"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45f7c5db-770c-4120-918a-1e630d5f3206"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CameraMove
        m_CameraMove = asset.FindActionMap("CameraMove", throwIfNotFound: true);
        m_CameraMove_RotateCamera = m_CameraMove.FindAction("RotateCamera", throwIfNotFound: true);
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

    // CameraMove
    private readonly InputActionMap m_CameraMove;
    private ICameraMoveActions m_CameraMoveActionsCallbackInterface;
    private readonly InputAction m_CameraMove_RotateCamera;
    public struct CameraMoveActions
    {
        private @MovementInput m_Wrapper;
        public CameraMoveActions(@MovementInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateCamera => m_Wrapper.m_CameraMove_RotateCamera;
        public InputActionMap Get() { return m_Wrapper.m_CameraMove; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraMoveActions set) { return set.Get(); }
        public void SetCallbacks(ICameraMoveActions instance)
        {
            if (m_Wrapper.m_CameraMoveActionsCallbackInterface != null)
            {
                @RotateCamera.started -= m_Wrapper.m_CameraMoveActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.performed -= m_Wrapper.m_CameraMoveActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.canceled -= m_Wrapper.m_CameraMoveActionsCallbackInterface.OnRotateCamera;
            }
            m_Wrapper.m_CameraMoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotateCamera.started += instance.OnRotateCamera;
                @RotateCamera.performed += instance.OnRotateCamera;
                @RotateCamera.canceled += instance.OnRotateCamera;
            }
        }
    }
    public CameraMoveActions @CameraMove => new CameraMoveActions(this);
    public interface ICameraMoveActions
    {
        void OnRotateCamera(InputAction.CallbackContext context);
    }
}
