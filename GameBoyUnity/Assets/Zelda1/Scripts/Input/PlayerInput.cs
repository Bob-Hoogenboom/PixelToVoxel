// GENERATED AUTOMATICALLY FROM 'Assets/Zelda1/Scripts/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Zelda1Controls"",
            ""id"": ""c0dff371-9563-4f39-a794-52b6440969f7"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""38390952-fec0-49a9-9180-9c41efa15d21"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""ee5c5cf6-6d68-4e1c-9274-1ce72b07bdaa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shield"",
                    ""type"": ""Button"",
                    ""id"": ""b973716c-5895-4e0b-b3ac-8eed3e948181"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FeatherJump"",
                    ""type"": ""Button"",
                    ""id"": ""8dfc3aa8-8082-40ef-9e9e-276ba4da850e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d04d5cc1-4b5e-4a5b-a4ef-6e5e7baa45b5"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""448d283f-a45d-462d-ab68-fa8d3fecf12c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b7adc80c-4c59-4940-b56a-909fd330c890"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a4574eeb-ea4f-4c98-a604-679132ad5db0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cfe0b33e-a405-419e-bfe8-743d22813b6b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ee2eeb53-2d0f-47e9-80c6-5ff12c5f0a84"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b9a4efd8-6f5f-4fdf-8d8b-03ee09281d8d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5df7417-03d4-429d-bd86-3407f5049819"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4aae05b7-e3a0-4caa-bbd9-bfdffb7f8502"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shield"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13770e17-0423-4555-b521-435d39606254"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shield"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4fdea508-d8af-4c2a-aec4-b54ed98f6b47"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FeatherJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MarioLandControls"",
            ""id"": ""30e87e25-48a8-4e99-8999-9811caa15c38"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""0489ce81-384a-43a9-a3ed-ed2364d3fabf"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""33a84466-7f51-4e60-a21d-7fcfeb0ead24"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CanonBallFlower"",
                    ""type"": ""Button"",
                    ""id"": ""4f09db44-c57b-491e-b20e-35ca1ef1a012"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""6c08d66e-7959-4c1a-9b1e-0963801caeb9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bf21c52e-9371-49aa-bd0a-b1cc0eaa0676"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""dcb67953-5498-4cbb-9184-852decb2d448"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8810a6af-5ba6-4c18-bcbb-5bc6406e0bc0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7c935c73-4cde-45d0-b608-c27eb2d778a4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e3436a7a-db9d-4476-9078-24bb47c469ee"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cf1d1c94-351b-4ea3-b5fe-bffdfac4b415"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f5ce160f-6fff-4cec-86d5-03abcb1ff954"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""919dccca-af0c-4957-8db6-edbaf9dfe7b7"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CanonBallFlower"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6614721c-a879-41e5-b331-187bbaa1c442"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""KartControls"",
            ""id"": ""212eab0b-d204-4ca5-8ffb-a46845f705f0"",
            ""actions"": [
                {
                    ""name"": ""Gas"",
                    ""type"": ""Button"",
                    ""id"": ""1ae2ba44-9780-41f3-8239-ee4df3970f5c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Break"",
                    ""type"": ""Button"",
                    ""id"": ""9272a5f8-b73a-4af6-b2ce-60586e51a839"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Button"",
                    ""id"": ""00c9173d-88a7-44af-bb9b-749a20d0cbf1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookBack"",
                    ""type"": ""Button"",
                    ""id"": ""b843fe6b-2500-4149-93ec-c37b3369b65f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drift"",
                    ""type"": ""Button"",
                    ""id"": ""8214cb3f-3529-421f-9e6b-0d10221b5384"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""eac9f0ae-a7fc-457e-bfcd-3bc0511a84e4"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a89d4852-5366-4125-a4f9-f4873e564dad"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92a3e095-1b81-482c-95d9-075d603a620b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72fd5c70-0279-4f57-86ae-c75130b3a29f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LookBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e07998e-0397-4e86-a4cb-c4decc918eb9"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Zelda1Controls
        m_Zelda1Controls = asset.FindActionMap("Zelda1Controls", throwIfNotFound: true);
        m_Zelda1Controls_Move = m_Zelda1Controls.FindAction("Move", throwIfNotFound: true);
        m_Zelda1Controls_Attack = m_Zelda1Controls.FindAction("Attack", throwIfNotFound: true);
        m_Zelda1Controls_Shield = m_Zelda1Controls.FindAction("Shield", throwIfNotFound: true);
        m_Zelda1Controls_FeatherJump = m_Zelda1Controls.FindAction("FeatherJump", throwIfNotFound: true);
        // MarioLandControls
        m_MarioLandControls = asset.FindActionMap("MarioLandControls", throwIfNotFound: true);
        m_MarioLandControls_Move = m_MarioLandControls.FindAction("Move", throwIfNotFound: true);
        m_MarioLandControls_Jump = m_MarioLandControls.FindAction("Jump", throwIfNotFound: true);
        m_MarioLandControls_CanonBallFlower = m_MarioLandControls.FindAction("CanonBallFlower", throwIfNotFound: true);
        m_MarioLandControls_Attack = m_MarioLandControls.FindAction("Attack", throwIfNotFound: true);
        // KartControls
        m_KartControls = asset.FindActionMap("KartControls", throwIfNotFound: true);
        m_KartControls_Gas = m_KartControls.FindAction("Gas", throwIfNotFound: true);
        m_KartControls_Break = m_KartControls.FindAction("Break", throwIfNotFound: true);
        m_KartControls_Turn = m_KartControls.FindAction("Turn", throwIfNotFound: true);
        m_KartControls_LookBack = m_KartControls.FindAction("LookBack", throwIfNotFound: true);
        m_KartControls_Drift = m_KartControls.FindAction("Drift", throwIfNotFound: true);
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

    // Zelda1Controls
    private readonly InputActionMap m_Zelda1Controls;
    private IZelda1ControlsActions m_Zelda1ControlsActionsCallbackInterface;
    private readonly InputAction m_Zelda1Controls_Move;
    private readonly InputAction m_Zelda1Controls_Attack;
    private readonly InputAction m_Zelda1Controls_Shield;
    private readonly InputAction m_Zelda1Controls_FeatherJump;
    public struct Zelda1ControlsActions
    {
        private @PlayerInput m_Wrapper;
        public Zelda1ControlsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Zelda1Controls_Move;
        public InputAction @Attack => m_Wrapper.m_Zelda1Controls_Attack;
        public InputAction @Shield => m_Wrapper.m_Zelda1Controls_Shield;
        public InputAction @FeatherJump => m_Wrapper.m_Zelda1Controls_FeatherJump;
        public InputActionMap Get() { return m_Wrapper.m_Zelda1Controls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Zelda1ControlsActions set) { return set.Get(); }
        public void SetCallbacks(IZelda1ControlsActions instance)
        {
            if (m_Wrapper.m_Zelda1ControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Zelda1ControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Zelda1ControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Zelda1ControlsActionsCallbackInterface.OnMove;
                @Attack.started -= m_Wrapper.m_Zelda1ControlsActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_Zelda1ControlsActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_Zelda1ControlsActionsCallbackInterface.OnAttack;
                @Shield.started -= m_Wrapper.m_Zelda1ControlsActionsCallbackInterface.OnShield;
                @Shield.performed -= m_Wrapper.m_Zelda1ControlsActionsCallbackInterface.OnShield;
                @Shield.canceled -= m_Wrapper.m_Zelda1ControlsActionsCallbackInterface.OnShield;
                @FeatherJump.started -= m_Wrapper.m_Zelda1ControlsActionsCallbackInterface.OnFeatherJump;
                @FeatherJump.performed -= m_Wrapper.m_Zelda1ControlsActionsCallbackInterface.OnFeatherJump;
                @FeatherJump.canceled -= m_Wrapper.m_Zelda1ControlsActionsCallbackInterface.OnFeatherJump;
            }
            m_Wrapper.m_Zelda1ControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Shield.started += instance.OnShield;
                @Shield.performed += instance.OnShield;
                @Shield.canceled += instance.OnShield;
                @FeatherJump.started += instance.OnFeatherJump;
                @FeatherJump.performed += instance.OnFeatherJump;
                @FeatherJump.canceled += instance.OnFeatherJump;
            }
        }
    }
    public Zelda1ControlsActions @Zelda1Controls => new Zelda1ControlsActions(this);

    // MarioLandControls
    private readonly InputActionMap m_MarioLandControls;
    private IMarioLandControlsActions m_MarioLandControlsActionsCallbackInterface;
    private readonly InputAction m_MarioLandControls_Move;
    private readonly InputAction m_MarioLandControls_Jump;
    private readonly InputAction m_MarioLandControls_CanonBallFlower;
    private readonly InputAction m_MarioLandControls_Attack;
    public struct MarioLandControlsActions
    {
        private @PlayerInput m_Wrapper;
        public MarioLandControlsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MarioLandControls_Move;
        public InputAction @Jump => m_Wrapper.m_MarioLandControls_Jump;
        public InputAction @CanonBallFlower => m_Wrapper.m_MarioLandControls_CanonBallFlower;
        public InputAction @Attack => m_Wrapper.m_MarioLandControls_Attack;
        public InputActionMap Get() { return m_Wrapper.m_MarioLandControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MarioLandControlsActions set) { return set.Get(); }
        public void SetCallbacks(IMarioLandControlsActions instance)
        {
            if (m_Wrapper.m_MarioLandControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MarioLandControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MarioLandControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MarioLandControlsActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_MarioLandControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MarioLandControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MarioLandControlsActionsCallbackInterface.OnJump;
                @CanonBallFlower.started -= m_Wrapper.m_MarioLandControlsActionsCallbackInterface.OnCanonBallFlower;
                @CanonBallFlower.performed -= m_Wrapper.m_MarioLandControlsActionsCallbackInterface.OnCanonBallFlower;
                @CanonBallFlower.canceled -= m_Wrapper.m_MarioLandControlsActionsCallbackInterface.OnCanonBallFlower;
                @Attack.started -= m_Wrapper.m_MarioLandControlsActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_MarioLandControlsActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_MarioLandControlsActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_MarioLandControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @CanonBallFlower.started += instance.OnCanonBallFlower;
                @CanonBallFlower.performed += instance.OnCanonBallFlower;
                @CanonBallFlower.canceled += instance.OnCanonBallFlower;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public MarioLandControlsActions @MarioLandControls => new MarioLandControlsActions(this);

    // KartControls
    private readonly InputActionMap m_KartControls;
    private IKartControlsActions m_KartControlsActionsCallbackInterface;
    private readonly InputAction m_KartControls_Gas;
    private readonly InputAction m_KartControls_Break;
    private readonly InputAction m_KartControls_Turn;
    private readonly InputAction m_KartControls_LookBack;
    private readonly InputAction m_KartControls_Drift;
    public struct KartControlsActions
    {
        private @PlayerInput m_Wrapper;
        public KartControlsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Gas => m_Wrapper.m_KartControls_Gas;
        public InputAction @Break => m_Wrapper.m_KartControls_Break;
        public InputAction @Turn => m_Wrapper.m_KartControls_Turn;
        public InputAction @LookBack => m_Wrapper.m_KartControls_LookBack;
        public InputAction @Drift => m_Wrapper.m_KartControls_Drift;
        public InputActionMap Get() { return m_Wrapper.m_KartControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KartControlsActions set) { return set.Get(); }
        public void SetCallbacks(IKartControlsActions instance)
        {
            if (m_Wrapper.m_KartControlsActionsCallbackInterface != null)
            {
                @Gas.started -= m_Wrapper.m_KartControlsActionsCallbackInterface.OnGas;
                @Gas.performed -= m_Wrapper.m_KartControlsActionsCallbackInterface.OnGas;
                @Gas.canceled -= m_Wrapper.m_KartControlsActionsCallbackInterface.OnGas;
                @Break.started -= m_Wrapper.m_KartControlsActionsCallbackInterface.OnBreak;
                @Break.performed -= m_Wrapper.m_KartControlsActionsCallbackInterface.OnBreak;
                @Break.canceled -= m_Wrapper.m_KartControlsActionsCallbackInterface.OnBreak;
                @Turn.started -= m_Wrapper.m_KartControlsActionsCallbackInterface.OnTurn;
                @Turn.performed -= m_Wrapper.m_KartControlsActionsCallbackInterface.OnTurn;
                @Turn.canceled -= m_Wrapper.m_KartControlsActionsCallbackInterface.OnTurn;
                @LookBack.started -= m_Wrapper.m_KartControlsActionsCallbackInterface.OnLookBack;
                @LookBack.performed -= m_Wrapper.m_KartControlsActionsCallbackInterface.OnLookBack;
                @LookBack.canceled -= m_Wrapper.m_KartControlsActionsCallbackInterface.OnLookBack;
                @Drift.started -= m_Wrapper.m_KartControlsActionsCallbackInterface.OnDrift;
                @Drift.performed -= m_Wrapper.m_KartControlsActionsCallbackInterface.OnDrift;
                @Drift.canceled -= m_Wrapper.m_KartControlsActionsCallbackInterface.OnDrift;
            }
            m_Wrapper.m_KartControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Gas.started += instance.OnGas;
                @Gas.performed += instance.OnGas;
                @Gas.canceled += instance.OnGas;
                @Break.started += instance.OnBreak;
                @Break.performed += instance.OnBreak;
                @Break.canceled += instance.OnBreak;
                @Turn.started += instance.OnTurn;
                @Turn.performed += instance.OnTurn;
                @Turn.canceled += instance.OnTurn;
                @LookBack.started += instance.OnLookBack;
                @LookBack.performed += instance.OnLookBack;
                @LookBack.canceled += instance.OnLookBack;
                @Drift.started += instance.OnDrift;
                @Drift.performed += instance.OnDrift;
                @Drift.canceled += instance.OnDrift;
            }
        }
    }
    public KartControlsActions @KartControls => new KartControlsActions(this);
    public interface IZelda1ControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnShield(InputAction.CallbackContext context);
        void OnFeatherJump(InputAction.CallbackContext context);
    }
    public interface IMarioLandControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCanonBallFlower(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
    public interface IKartControlsActions
    {
        void OnGas(InputAction.CallbackContext context);
        void OnBreak(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
        void OnLookBack(InputAction.CallbackContext context);
        void OnDrift(InputAction.CallbackContext context);
    }
}
