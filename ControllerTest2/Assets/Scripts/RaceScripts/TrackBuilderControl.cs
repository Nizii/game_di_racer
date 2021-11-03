// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/TrackBuilderControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TrackBuilderControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TrackBuilderControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TrackBuilderControl"",
    ""maps"": [
        {
            ""name"": ""TrackBuilder"",
            ""id"": ""bb560fff-a5c5-42ed-8a08-1e42c1dc0432"",
            ""actions"": [
                {
                    ""name"": ""LeftRight"",
                    ""type"": ""Value"",
                    ""id"": ""84566b06-ea05-42d6-8a8c-9f72c7c851cb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UpDown"",
                    ""type"": ""Value"",
                    ""id"": ""d2cbb077-ff94-4a4b-8149-44de789e660b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""YawLeft"",
                    ""type"": ""Value"",
                    ""id"": ""99fcf8e2-99f6-4789-aeb9-eee0ebd473bf"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""YawRight"",
                    ""type"": ""Value"",
                    ""id"": ""d2d3a10a-c90e-4033-b1e5-762d294dfebe"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fbd98f84-feeb-4b09-ab9a-46fedec68ef7"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6a78e4f-93a7-421e-8ee2-923a003d3fa7"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(y=0.9)"",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6aa4f94-47be-47ed-b9e1-2f0c8aaccca2"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YawLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f141443c-91ca-4f11-8256-fc999e13cc41"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YawRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // TrackBuilder
        m_TrackBuilder = asset.FindActionMap("TrackBuilder", throwIfNotFound: true);
        m_TrackBuilder_LeftRight = m_TrackBuilder.FindAction("LeftRight", throwIfNotFound: true);
        m_TrackBuilder_UpDown = m_TrackBuilder.FindAction("UpDown", throwIfNotFound: true);
        m_TrackBuilder_YawLeft = m_TrackBuilder.FindAction("YawLeft", throwIfNotFound: true);
        m_TrackBuilder_YawRight = m_TrackBuilder.FindAction("YawRight", throwIfNotFound: true);
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

    // TrackBuilder
    private readonly InputActionMap m_TrackBuilder;
    private ITrackBuilderActions m_TrackBuilderActionsCallbackInterface;
    private readonly InputAction m_TrackBuilder_LeftRight;
    private readonly InputAction m_TrackBuilder_UpDown;
    private readonly InputAction m_TrackBuilder_YawLeft;
    private readonly InputAction m_TrackBuilder_YawRight;
    public struct TrackBuilderActions
    {
        private @TrackBuilderControl m_Wrapper;
        public TrackBuilderActions(@TrackBuilderControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftRight => m_Wrapper.m_TrackBuilder_LeftRight;
        public InputAction @UpDown => m_Wrapper.m_TrackBuilder_UpDown;
        public InputAction @YawLeft => m_Wrapper.m_TrackBuilder_YawLeft;
        public InputAction @YawRight => m_Wrapper.m_TrackBuilder_YawRight;
        public InputActionMap Get() { return m_Wrapper.m_TrackBuilder; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TrackBuilderActions set) { return set.Get(); }
        public void SetCallbacks(ITrackBuilderActions instance)
        {
            if (m_Wrapper.m_TrackBuilderActionsCallbackInterface != null)
            {
                @LeftRight.started -= m_Wrapper.m_TrackBuilderActionsCallbackInterface.OnLeftRight;
                @LeftRight.performed -= m_Wrapper.m_TrackBuilderActionsCallbackInterface.OnLeftRight;
                @LeftRight.canceled -= m_Wrapper.m_TrackBuilderActionsCallbackInterface.OnLeftRight;
                @UpDown.started -= m_Wrapper.m_TrackBuilderActionsCallbackInterface.OnUpDown;
                @UpDown.performed -= m_Wrapper.m_TrackBuilderActionsCallbackInterface.OnUpDown;
                @UpDown.canceled -= m_Wrapper.m_TrackBuilderActionsCallbackInterface.OnUpDown;
                @YawLeft.started -= m_Wrapper.m_TrackBuilderActionsCallbackInterface.OnYawLeft;
                @YawLeft.performed -= m_Wrapper.m_TrackBuilderActionsCallbackInterface.OnYawLeft;
                @YawLeft.canceled -= m_Wrapper.m_TrackBuilderActionsCallbackInterface.OnYawLeft;
                @YawRight.started -= m_Wrapper.m_TrackBuilderActionsCallbackInterface.OnYawRight;
                @YawRight.performed -= m_Wrapper.m_TrackBuilderActionsCallbackInterface.OnYawRight;
                @YawRight.canceled -= m_Wrapper.m_TrackBuilderActionsCallbackInterface.OnYawRight;
            }
            m_Wrapper.m_TrackBuilderActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftRight.started += instance.OnLeftRight;
                @LeftRight.performed += instance.OnLeftRight;
                @LeftRight.canceled += instance.OnLeftRight;
                @UpDown.started += instance.OnUpDown;
                @UpDown.performed += instance.OnUpDown;
                @UpDown.canceled += instance.OnUpDown;
                @YawLeft.started += instance.OnYawLeft;
                @YawLeft.performed += instance.OnYawLeft;
                @YawLeft.canceled += instance.OnYawLeft;
                @YawRight.started += instance.OnYawRight;
                @YawRight.performed += instance.OnYawRight;
                @YawRight.canceled += instance.OnYawRight;
            }
        }
    }
    public TrackBuilderActions @TrackBuilder => new TrackBuilderActions(this);
    public interface ITrackBuilderActions
    {
        void OnLeftRight(InputAction.CallbackContext context);
        void OnUpDown(InputAction.CallbackContext context);
        void OnYawLeft(InputAction.CallbackContext context);
        void OnYawRight(InputAction.CallbackContext context);
    }
}
