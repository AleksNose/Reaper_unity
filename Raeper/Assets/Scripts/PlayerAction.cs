// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerAction"",
    ""maps"": [
        {
            ""name"": ""Land"",
            ""id"": ""2996b2b5-2748-4b4f-b6bb-5337bc10d170"",
            ""actions"": [
                {
                    ""name"": ""Vertical"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7a698b3c-74ca-4d4c-b5fc-fc64f3bc9af5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Button"",
                    ""id"": ""4849b507-6589-49a7-88b7-d781ab1dae19"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ver"",
                    ""id"": ""1d566fcf-cbbc-41ef-a0d2-3306360113aa"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""87365d47-dd1d-4979-9eed-6749e6466f0b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""97f734f5-35a3-4c2c-9df5-460d6838037a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""hol"",
                    ""id"": ""6d1d3a1a-763b-482f-a873-0fe4dd39e4a9"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""600fbb19-041a-48db-88cd-0eb2b2757614"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2eb90f7c-d6e0-4ef6-9ed8-8ae37456544a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Interact"",
            ""id"": ""726683f5-ffb9-4aff-8a9a-c3101e664572"",
            ""actions"": [
                {
                    ""name"": ""ChangeCharacter"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2dcb84ba-3be7-4f43-8eb4-3402968532ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""KillPerson"",
                    ""type"": ""Button"",
                    ""id"": ""406ab118-9980-47fd-91e4-7b2740090a9a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b29101f6-7f9f-43c6-9785-b1f7a5eeac5f"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCharacter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7144858b-2023-435f-be1c-5d58d6e2508c"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KillPerson"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Land
        m_Land = asset.FindActionMap("Land", throwIfNotFound: true);
        m_Land_Vertical = m_Land.FindAction("Vertical", throwIfNotFound: true);
        m_Land_Horizontal = m_Land.FindAction("Horizontal", throwIfNotFound: true);
        // Interact
        m_Interact = asset.FindActionMap("Interact", throwIfNotFound: true);
        m_Interact_ChangeCharacter = m_Interact.FindAction("ChangeCharacter", throwIfNotFound: true);
        m_Interact_KillPerson = m_Interact.FindAction("KillPerson", throwIfNotFound: true);
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

    // Land
    private readonly InputActionMap m_Land;
    private ILandActions m_LandActionsCallbackInterface;
    private readonly InputAction m_Land_Vertical;
    private readonly InputAction m_Land_Horizontal;
    public struct LandActions
    {
        private @PlayerAction m_Wrapper;
        public LandActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Vertical => m_Wrapper.m_Land_Vertical;
        public InputAction @Horizontal => m_Wrapper.m_Land_Horizontal;
        public InputActionMap Get() { return m_Wrapper.m_Land; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandActions set) { return set.Get(); }
        public void SetCallbacks(ILandActions instance)
        {
            if (m_Wrapper.m_LandActionsCallbackInterface != null)
            {
                @Vertical.started -= m_Wrapper.m_LandActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnVertical;
                @Horizontal.started -= m_Wrapper.m_LandActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnHorizontal;
            }
            m_Wrapper.m_LandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
            }
        }
    }
    public LandActions @Land => new LandActions(this);

    // Interact
    private readonly InputActionMap m_Interact;
    private IInteractActions m_InteractActionsCallbackInterface;
    private readonly InputAction m_Interact_ChangeCharacter;
    private readonly InputAction m_Interact_KillPerson;
    public struct InteractActions
    {
        private @PlayerAction m_Wrapper;
        public InteractActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @ChangeCharacter => m_Wrapper.m_Interact_ChangeCharacter;
        public InputAction @KillPerson => m_Wrapper.m_Interact_KillPerson;
        public InputActionMap Get() { return m_Wrapper.m_Interact; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractActions set) { return set.Get(); }
        public void SetCallbacks(IInteractActions instance)
        {
            if (m_Wrapper.m_InteractActionsCallbackInterface != null)
            {
                @ChangeCharacter.started -= m_Wrapper.m_InteractActionsCallbackInterface.OnChangeCharacter;
                @ChangeCharacter.performed -= m_Wrapper.m_InteractActionsCallbackInterface.OnChangeCharacter;
                @ChangeCharacter.canceled -= m_Wrapper.m_InteractActionsCallbackInterface.OnChangeCharacter;
                @KillPerson.started -= m_Wrapper.m_InteractActionsCallbackInterface.OnKillPerson;
                @KillPerson.performed -= m_Wrapper.m_InteractActionsCallbackInterface.OnKillPerson;
                @KillPerson.canceled -= m_Wrapper.m_InteractActionsCallbackInterface.OnKillPerson;
            }
            m_Wrapper.m_InteractActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ChangeCharacter.started += instance.OnChangeCharacter;
                @ChangeCharacter.performed += instance.OnChangeCharacter;
                @ChangeCharacter.canceled += instance.OnChangeCharacter;
                @KillPerson.started += instance.OnKillPerson;
                @KillPerson.performed += instance.OnKillPerson;
                @KillPerson.canceled += instance.OnKillPerson;
            }
        }
    }
    public InteractActions @Interact => new InteractActions(this);
    public interface ILandActions
    {
        void OnVertical(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
    }
    public interface IInteractActions
    {
        void OnChangeCharacter(InputAction.CallbackContext context);
        void OnKillPerson(InputAction.CallbackContext context);
    }
}
