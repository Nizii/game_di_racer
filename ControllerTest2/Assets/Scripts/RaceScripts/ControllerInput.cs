// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/RaceScripts/ControllerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControllerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControllerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControllerInput"",
    ""maps"": [
        {
            ""name"": ""Racer"",
            ""id"": ""5e7af1fc-3aa2-4faf-9ed1-32922d84173a"",
            ""actions"": [
                {
                    ""name"": ""RacerMove"",
                    ""type"": ""Value"",
                    ""id"": ""be7d6998-6c00-4be5-8fff-e9029c26e31b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e5db4d64-6c53-4721-a94a-4427dd82b899"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller1"",
                    ""action"": ""RacerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Tracker"",
            ""id"": ""0ffb071d-ef48-4913-9af6-9b4c58ac1275"",
            ""actions"": [
                {
                    ""name"": ""TrackerMove"",
                    ""type"": ""Value"",
                    ""id"": ""2dce8f35-722e-40fc-a679-a2d0a98ef559"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b3640d2e-0824-4bf8-b76b-983190de8ff6"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller2"",
                    ""action"": ""TrackerMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""92958315-dc47-4668-aaf7-c5259fcb980b"",
            ""actions"": [
                {
                    ""name"": ""ButtonDown"",
                    ""type"": ""Button"",
                    ""id"": ""93f1da14-df68-413e-a2e1-f8f72bc73159"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonUp"",
                    ""type"": ""Button"",
                    ""id"": ""b4e44371-8d12-4e6e-adef-93832d9e6049"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Enter"",
                    ""type"": ""Button"",
                    ""id"": ""5845f635-53e0-4e9e-a11e-038c9d5d10fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b766f94f-cb5a-4229-873a-d5072e36376b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0db6bf62-1d5e-4005-806c-ec30131fd48f"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd53b07e-b186-43f6-b3ac-28f0b2f6ebe9"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8695214-211c-42b5-9123-307481d75cd5"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ButtonUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8ca1cbe-9e06-4b02-968a-9b9cfbce6566"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Controller1"",
            ""bindingGroup"": ""Controller1"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller2"",
            ""bindingGroup"": ""Controller2"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Racer
        m_Racer = asset.FindActionMap("Racer", throwIfNotFound: true);
        m_Racer_RacerMove = m_Racer.FindAction("RacerMove", throwIfNotFound: true);
        // Tracker
        m_Tracker = asset.FindActionMap("Tracker", throwIfNotFound: true);
        m_Tracker_TrackerMove = m_Tracker.FindAction("TrackerMove", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_ButtonDown = m_Menu.FindAction("ButtonDown", throwIfNotFound: true);
        m_Menu_ButtonUp = m_Menu.FindAction("ButtonUp", throwIfNotFound: true);
        m_Menu_Enter = m_Menu.FindAction("Enter", throwIfNotFound: true);
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

    // Racer
    private readonly InputActionMap m_Racer;
    private IRacerActions m_RacerActionsCallbackInterface;
    private readonly InputAction m_Racer_RacerMove;
    public struct RacerActions
    {
        private @ControllerInput m_Wrapper;
        public RacerActions(@ControllerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @RacerMove => m_Wrapper.m_Racer_RacerMove;
        public InputActionMap Get() { return m_Wrapper.m_Racer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RacerActions set) { return set.Get(); }
        public void SetCallbacks(IRacerActions instance)
        {
            if (m_Wrapper.m_RacerActionsCallbackInterface != null)
            {
                @RacerMove.started -= m_Wrapper.m_RacerActionsCallbackInterface.OnRacerMove;
                @RacerMove.performed -= m_Wrapper.m_RacerActionsCallbackInterface.OnRacerMove;
                @RacerMove.canceled -= m_Wrapper.m_RacerActionsCallbackInterface.OnRacerMove;
            }
            m_Wrapper.m_RacerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RacerMove.started += instance.OnRacerMove;
                @RacerMove.performed += instance.OnRacerMove;
                @RacerMove.canceled += instance.OnRacerMove;
            }
        }
    }
    public RacerActions @Racer => new RacerActions(this);

    // Tracker
    private readonly InputActionMap m_Tracker;
    private ITrackerActions m_TrackerActionsCallbackInterface;
    private readonly InputAction m_Tracker_TrackerMove;
    public struct TrackerActions
    {
        private @ControllerInput m_Wrapper;
        public TrackerActions(@ControllerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @TrackerMove => m_Wrapper.m_Tracker_TrackerMove;
        public InputActionMap Get() { return m_Wrapper.m_Tracker; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TrackerActions set) { return set.Get(); }
        public void SetCallbacks(ITrackerActions instance)
        {
            if (m_Wrapper.m_TrackerActionsCallbackInterface != null)
            {
                @TrackerMove.started -= m_Wrapper.m_TrackerActionsCallbackInterface.OnTrackerMove;
                @TrackerMove.performed -= m_Wrapper.m_TrackerActionsCallbackInterface.OnTrackerMove;
                @TrackerMove.canceled -= m_Wrapper.m_TrackerActionsCallbackInterface.OnTrackerMove;
            }
            m_Wrapper.m_TrackerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TrackerMove.started += instance.OnTrackerMove;
                @TrackerMove.performed += instance.OnTrackerMove;
                @TrackerMove.canceled += instance.OnTrackerMove;
            }
        }
    }
    public TrackerActions @Tracker => new TrackerActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_ButtonDown;
    private readonly InputAction m_Menu_ButtonUp;
    private readonly InputAction m_Menu_Enter;
    public struct MenuActions
    {
        private @ControllerInput m_Wrapper;
        public MenuActions(@ControllerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ButtonDown => m_Wrapper.m_Menu_ButtonDown;
        public InputAction @ButtonUp => m_Wrapper.m_Menu_ButtonUp;
        public InputAction @Enter => m_Wrapper.m_Menu_Enter;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @ButtonDown.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnButtonDown;
                @ButtonDown.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnButtonDown;
                @ButtonDown.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnButtonDown;
                @ButtonUp.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnButtonUp;
                @ButtonUp.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnButtonUp;
                @ButtonUp.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnButtonUp;
                @Enter.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnEnter;
                @Enter.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnEnter;
                @Enter.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnEnter;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ButtonDown.started += instance.OnButtonDown;
                @ButtonDown.performed += instance.OnButtonDown;
                @ButtonDown.canceled += instance.OnButtonDown;
                @ButtonUp.started += instance.OnButtonUp;
                @ButtonUp.performed += instance.OnButtonUp;
                @ButtonUp.canceled += instance.OnButtonUp;
                @Enter.started += instance.OnEnter;
                @Enter.performed += instance.OnEnter;
                @Enter.canceled += instance.OnEnter;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int m_Controller1SchemeIndex = -1;
    public InputControlScheme Controller1Scheme
    {
        get
        {
            if (m_Controller1SchemeIndex == -1) m_Controller1SchemeIndex = asset.FindControlSchemeIndex("Controller1");
            return asset.controlSchemes[m_Controller1SchemeIndex];
        }
    }
    private int m_Controller2SchemeIndex = -1;
    public InputControlScheme Controller2Scheme
    {
        get
        {
            if (m_Controller2SchemeIndex == -1) m_Controller2SchemeIndex = asset.FindControlSchemeIndex("Controller2");
            return asset.controlSchemes[m_Controller2SchemeIndex];
        }
    }
    public interface IRacerActions
    {
        void OnRacerMove(InputAction.CallbackContext context);
    }
    public interface ITrackerActions
    {
        void OnTrackerMove(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnButtonDown(InputAction.CallbackContext context);
        void OnButtonUp(InputAction.CallbackContext context);
        void OnEnter(InputAction.CallbackContext context);
    }
}
