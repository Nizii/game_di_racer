// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerOneInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerOneInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerOneInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerOneInput"",
    ""maps"": [
        {
            ""name"": ""PlayerOne"",
            ""id"": ""9ac47645-8caa-4feb-9201-1f9912ad0fb1"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""7e1d9210-ac00-4e9d-8503-261b482f6bbf"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Press"",
                    ""type"": ""Button"",
                    ""id"": ""832e7163-de2c-47bd-8799-860409c9c6ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""d22d1a88-98fd-45be-9c3b-3af436fcf128"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""df7f78c8-eaaf-490d-ae8b-3a52e098786e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""89a31e6a-248d-49ae-b7f0-853fb0586721"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3b490ae-9cbc-413d-9362-a09da3b851b8"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1891af4b-1c55-4fa4-b49b-d2051c737447"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerOne
        m_PlayerOne = asset.FindActionMap("PlayerOne", throwIfNotFound: true);
        m_PlayerOne_Move = m_PlayerOne.FindAction("Move", throwIfNotFound: true);
        m_PlayerOne_Press = m_PlayerOne.FindAction("Press", throwIfNotFound: true);
        m_PlayerOne_Menu = m_PlayerOne.FindAction("Menu", throwIfNotFound: true);
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

    // PlayerOne
    private readonly InputActionMap m_PlayerOne;
    private IPlayerOneActions m_PlayerOneActionsCallbackInterface;
    private readonly InputAction m_PlayerOne_Move;
    private readonly InputAction m_PlayerOne_Press;
    private readonly InputAction m_PlayerOne_Menu;
    public struct PlayerOneActions
    {
        private @PlayerOneInput m_Wrapper;
        public PlayerOneActions(@PlayerOneInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerOne_Move;
        public InputAction @Press => m_Wrapper.m_PlayerOne_Press;
        public InputAction @Menu => m_Wrapper.m_PlayerOne_Menu;
        public InputActionMap Get() { return m_Wrapper.m_PlayerOne; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerOneActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerOneActions instance)
        {
            if (m_Wrapper.m_PlayerOneActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMove;
                @Press.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnPress;
                @Press.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnPress;
                @Press.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnPress;
                @Menu.started -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_PlayerOneActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_PlayerOneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Press.started += instance.OnPress;
                @Press.performed += instance.OnPress;
                @Press.canceled += instance.OnPress;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public PlayerOneActions @PlayerOne => new PlayerOneActions(this);
    public interface IPlayerOneActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnPress(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
}
