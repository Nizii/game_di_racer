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
            ""name"": ""Menu"",
            ""id"": ""0423e94e-ab4f-41df-8238-ea37b221ead1"",
            ""actions"": [
                {
                    ""name"": ""ButtonUp"",
                    ""type"": ""Button"",
                    ""id"": ""ca396918-9586-408e-8ab0-e08926a8cc61"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ButtonDown"",
                    ""type"": ""Button"",
                    ""id"": ""e8f891c1-4121-44c8-a7c7-67805a75fa12"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Play"",
                    ""type"": ""Button"",
                    ""id"": ""aaa14d8b-26ee-4c32-9937-5a29dedbb24e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f6a7aae2-f4d1-4b7d-be95-a3164ac97235"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone,AxisDeadzone"",
                    ""groups"": ""Controller1"",
                    ""action"": ""ButtonUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8dbfaea-3c39-47d5-be66-8df3ed0b949f"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone,AxisDeadzone"",
                    ""groups"": ""Controller1"",
                    ""action"": ""ButtonDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac3bf203-ff89-422d-bf9e-f1af1f3c25da"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller1"",
                    ""action"": ""Play"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Tracker"",
            ""id"": ""4682abc6-3b0b-4aa0-86b0-614316b5b62d"",
            ""actions"": [
                {
                    ""name"": ""TrackMove"",
                    ""type"": ""Value"",
                    ""id"": ""c8d8d659-c638-4c94-83ed-a9f9382efb5f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""99c5d310-1eaa-4fbc-84b1-d11cc9e716c2"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller2"",
                    ""action"": ""TrackMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17a5ad16-a68f-48a1-8cbe-5dc35a90a270"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller2;Controller1"",
                    ""action"": ""TrackMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Racer"",
            ""id"": ""55a656b6-70d9-4fa9-a74f-789e3159f5ef"",
            ""actions"": [
                {
                    ""name"": ""RacerMove"",
                    ""type"": ""Value"",
                    ""id"": ""a52a9ed2-63b3-4fbc-8a28-8d5f28ce6c75"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""00a89acd-0a53-4125-bd7a-53ac2b049b8b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller1"",
                    ""action"": ""RacerMove"",
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
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
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
                }
            ]
        }
    ]
}");
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_ButtonUp = m_Menu.FindAction("ButtonUp", throwIfNotFound: true);
        m_Menu_ButtonDown = m_Menu.FindAction("ButtonDown", throwIfNotFound: true);
        m_Menu_Play = m_Menu.FindAction("Play", throwIfNotFound: true);
        // Tracker
        m_Tracker = asset.FindActionMap("Tracker", throwIfNotFound: true);
        m_Tracker_TrackMove = m_Tracker.FindAction("TrackMove", throwIfNotFound: true);
        // Racer
        m_Racer = asset.FindActionMap("Racer", throwIfNotFound: true);
        m_Racer_RacerMove = m_Racer.FindAction("RacerMove", throwIfNotFound: true);
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

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_ButtonUp;
    private readonly InputAction m_Menu_ButtonDown;
    private readonly InputAction m_Menu_Play;
    public struct MenuActions
    {
        private @ControllerInput m_Wrapper;
        public MenuActions(@ControllerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ButtonUp => m_Wrapper.m_Menu_ButtonUp;
        public InputAction @ButtonDown => m_Wrapper.m_Menu_ButtonDown;
        public InputAction @Play => m_Wrapper.m_Menu_Play;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @ButtonUp.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnButtonUp;
                @ButtonUp.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnButtonUp;
                @ButtonUp.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnButtonUp;
                @ButtonDown.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnButtonDown;
                @ButtonDown.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnButtonDown;
                @ButtonDown.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnButtonDown;
                @Play.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPlay;
                @Play.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPlay;
                @Play.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPlay;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ButtonUp.started += instance.OnButtonUp;
                @ButtonUp.performed += instance.OnButtonUp;
                @ButtonUp.canceled += instance.OnButtonUp;
                @ButtonDown.started += instance.OnButtonDown;
                @ButtonDown.performed += instance.OnButtonDown;
                @ButtonDown.canceled += instance.OnButtonDown;
                @Play.started += instance.OnPlay;
                @Play.performed += instance.OnPlay;
                @Play.canceled += instance.OnPlay;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // Tracker
    private readonly InputActionMap m_Tracker;
    private ITrackerActions m_TrackerActionsCallbackInterface;
    private readonly InputAction m_Tracker_TrackMove;
    public struct TrackerActions
    {
        private @ControllerInput m_Wrapper;
        public TrackerActions(@ControllerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @TrackMove => m_Wrapper.m_Tracker_TrackMove;
        public InputActionMap Get() { return m_Wrapper.m_Tracker; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TrackerActions set) { return set.Get(); }
        public void SetCallbacks(ITrackerActions instance)
        {
            if (m_Wrapper.m_TrackerActionsCallbackInterface != null)
            {
                @TrackMove.started -= m_Wrapper.m_TrackerActionsCallbackInterface.OnTrackMove;
                @TrackMove.performed -= m_Wrapper.m_TrackerActionsCallbackInterface.OnTrackMove;
                @TrackMove.canceled -= m_Wrapper.m_TrackerActionsCallbackInterface.OnTrackMove;
            }
            m_Wrapper.m_TrackerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TrackMove.started += instance.OnTrackMove;
                @TrackMove.performed += instance.OnTrackMove;
                @TrackMove.canceled += instance.OnTrackMove;
            }
        }
    }
    public TrackerActions @Tracker => new TrackerActions(this);

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
    private int m_Controller1SchemeIndex = -1;
    public InputControlScheme Controller1Scheme
    {
        get
        {
            if (m_Controller1SchemeIndex == -1) m_Controller1SchemeIndex = asset.FindControlSchemeIndex("Controller1");
            return asset.controlSchemes[m_Controller1SchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
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
    public interface IMenuActions
    {
        void OnButtonUp(InputAction.CallbackContext context);
        void OnButtonDown(InputAction.CallbackContext context);
        void OnPlay(InputAction.CallbackContext context);
    }
    public interface ITrackerActions
    {
        void OnTrackMove(InputAction.CallbackContext context);
    }
    public interface IRacerActions
    {
        void OnRacerMove(InputAction.CallbackContext context);
    }
}
