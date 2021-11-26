// GENERATED AUTOMATICALLY FROM 'Assets/Samples/XR Interaction Toolkit/1.0.0-pre.8/XR Device Simulator/XR Device Simulator Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @XRDeviceSimulatorControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @XRDeviceSimulatorControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""XR Device Simulator Controls"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""c96c4ddb-3eb8-4074-bbd9-a8ae6f1f6475"",
            ""actions"": [
                {
                    ""name"": ""Keyboard X Translate"",
                    ""type"": ""Value"",
                    ""id"": ""d4eb7006-5077-4816-9d5c-f570b6d586f3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Keyboard Z Translate"",
                    ""type"": ""Value"",
                    ""id"": ""3ea275ac-e111-4610-891f-105676c72cd5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Keyboard Y Translate"",
                    ""type"": ""Value"",
                    ""id"": ""5cc58f95-e9dc-4675-a42e-dd66874c3ba3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Manipulate LeftHand"",
                    ""type"": ""Button"",
                    ""id"": ""07c46cc4-c35d-4364-a878-68fad8ab8c64"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Manipulate RightHand"",
                    ""type"": ""Button"",
                    ""id"": ""307cb608-f32e-48a3-8ce6-d1cd83a5fb90"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Toggle Manipulate LeftHand"",
                    ""type"": ""Button"",
                    ""id"": ""847b79d9-a69b-4484-8688-a4bf40e58163"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Toggle Manipulate RightHand"",
                    ""type"": ""Button"",
                    ""id"": ""241f6068-ebc8-4c6d-b747-8bc2c1f74f87"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Manipulate Head"",
                    ""type"": ""Button"",
                    ""id"": ""f5febf74-651b-4f73-8d0a-08b0acdabc4d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse Delta"",
                    ""type"": ""Value"",
                    ""id"": ""0b945dbf-d750-40cb-97c6-593686fcf012"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse Scroll"",
                    ""type"": ""Value"",
                    ""id"": ""b2a408da-a9fd-4638-9af3-17fb9bc2811d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate Mode Override"",
                    ""type"": ""Button"",
                    ""id"": ""2e390909-c0f6-4ca5-b8bc-4c54090f96d9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Toggle Mouse Transformation Mode"",
                    ""type"": ""Button"",
                    ""id"": ""ae2b5c7f-b5e0-4b93-b674-172de9f68380"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Negate Mode"",
                    ""type"": ""Button"",
                    ""id"": ""8c837143-e018-41f0-9e0e-907acb9d7360"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Z Constraint"",
                    ""type"": ""Button"",
                    ""id"": ""d3e9308c-6f8c-46f7-bb6f-14422c345983"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""X Constraint"",
                    ""type"": ""Button"",
                    ""id"": ""11dc7a94-7230-49ff-b56d-06e6473e9951"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Y Constraint"",
                    ""type"": ""Button"",
                    ""id"": ""11ab79c6-b9c6-4301-8086-3e9c6904ef14"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""339ccb79-aee9-4ba4-8864-3b6c81c199db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Toggle Cursor Lock"",
                    ""type"": ""Button"",
                    ""id"": ""9bd36ab1-f676-4ff4-8a4d-ba0c6fb36268"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""db741065-2a46-439d-9e13-11960dc3355a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keyboard X Translate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3d2e07de-025e-4c2e-98df-250511a8ff6d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keyboard X Translate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""04e1437d-c862-4a04-8f8e-40e9f52c4f5e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keyboard X Translate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""cb7c4679-31f4-4170-885a-e7d78c049443"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keyboard Z Translate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""732e790c-f2a2-4f90-b525-53139a358de7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keyboard Z Translate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d5a98916-ade7-419d-a138-86bcdf05670f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keyboard Z Translate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""fca20498-bf6f-4824-ba15-6dc2d191eb2f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keyboard Y Translate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2c01790c-a24a-4266-a2e9-74e2a1ca3fa7"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keyboard Y Translate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f5223aed-93c0-4633-8aa3-c393ce890872"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Keyboard Y Translate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fcfb16fb-edee-474c-b1f2-f10b2a0a3569"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Manipulate LeftHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e791caef-78d3-4f68-9104-212f73ac0642"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Manipulate RightHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b62df009-54c9-4b03-9721-07ca66fe1bdf"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Toggle Manipulate LeftHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8a0a3b9-06cf-40a8-86d8-1d8f1d704451"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Toggle Manipulate RightHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2c1b1cd-6ea7-45b6-b68f-17b3662b4d3a"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse Delta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66e536bc-b5b6-4c7b-903a-fbcc05fc854e"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b070a4a-e044-4cbd-a8e2-6b362785bf21"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate Mode Override"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0fa0d566-1e07-4e17-9b14-3e8fce69ec26"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""X Constraint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71c185e1-73fb-4691-b910-70610f397b42"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y Constraint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09809c10-d09e-4c49-b58f-1995e50cf685"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Z Constraint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7611d6eb-0ff4-431f-998d-6fa429e0e1e1"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Toggle Mouse Transformation Mode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c889b78-f9fd-4cd7-96dd-5399428f6992"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Negate Mode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85f27bdb-dfe8-48d3-8512-205b3ad6306a"",
                    ""path"": ""<Keyboard>/backslash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Toggle Cursor Lock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3542472e-e883-407a-b967-5b879b2d7dc4"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Manipulate Head"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd7dcdd6-b569-4c25-87ea-c62a0fb1cf89"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Input Controls"",
            ""id"": ""404d9e15-a8bc-4b52-89e8-048203e913fa"",
            ""actions"": [
                {
                    ""name"": ""Axis 2D"",
                    ""type"": ""Value"",
                    ""id"": ""12cda119-7fbf-4f67-9db5-e5ad3b7905ca"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Resting Hand Axis 2D"",
                    ""type"": ""Value"",
                    ""id"": ""a2176ee2-e6ed-44a9-a5ee-858b1a6089fa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Toggle Device Position Target"",
                    ""type"": ""Button"",
                    ""id"": ""15cd3c4a-56b1-4a43-a924-a2118e2adaf4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Toggle Primary 2D Axis Target"",
                    ""type"": ""Button"",
                    ""id"": ""e0fdec2d-309b-4313-aad7-9dcc71f1394d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Toggle Secondary 2D Axis Target"",
                    ""type"": ""Button"",
                    ""id"": ""b3b49ea5-f80f-4d24-a782-d61a13a004b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grip"",
                    ""type"": ""Button"",
                    ""id"": ""99383123-529b-44b3-be25-fc03e45b0117"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Trigger"",
                    ""type"": ""Button"",
                    ""id"": ""4c755f54-9a5b-4ab4-8971-86e750cce8c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary Button"",
                    ""type"": ""Button"",
                    ""id"": ""f21a59fc-ba2d-43ac-9051-f61598c360bd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary Button"",
                    ""type"": ""Button"",
                    ""id"": ""33caae29-953d-46ee-8327-c9279a3e6112"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""4c344ddd-429e-4075-bf61-7d7a4915c0f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary 2D Axis Click"",
                    ""type"": ""Button"",
                    ""id"": ""c98dc3c2-51e8-4d47-b5e8-9fbe8f357cea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary 2D Axis Click"",
                    ""type"": ""Button"",
                    ""id"": ""9a69a85f-8b0d-4959-94ff-a159876275d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary 2D Axis Touch"",
                    ""type"": ""Button"",
                    ""id"": ""068c19f3-3201-418a-b101-88dcc47aa2fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary 2D Axis Touch"",
                    ""type"": ""Button"",
                    ""id"": ""ec51a057-e484-434d-b335-03f16cfcf26d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary Touch"",
                    ""type"": ""Button"",
                    ""id"": ""7ce78a0e-a94b-49fa-b3d5-5fca18de3391"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary Touch"",
                    ""type"": ""Button"",
                    ""id"": ""bd4f8d55-321e-4d2c-8215-c85c461b37eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""909c7e62-e6ea-4683-8b23-883ad4898d18"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis 2D"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0c29f651-2c07-4554-b2e8-dab5be5b2e87"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis 2D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7a9f0789-f285-4c25-b1f4-c4f34c4d0451"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis 2D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""905af182-924d-46b5-94d3-e22db48c4085"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis 2D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""88e79231-cdb4-400a-8980-b4576ee0a263"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis 2D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9404bec7-672a-4fb1-adb3-e2dc4e32801b"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Toggle Device Position Target"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4bfdd0e6-1936-4f44-8e97-20e16dbc879f"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Toggle Primary 2D Axis Target"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81d47d9e-4920-4098-94d8-bac2888d6433"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Toggle Secondary 2D Axis Target"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""82126405-60e1-49f1-9b69-e965eaacb8ee"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resting Hand Axis 2D"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e27996d4-255f-4240-a9a6-fd8714a69a0c"",
                    ""path"": ""<Mouse>/forwardButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resting Hand Axis 2D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""77a74547-37ef-4713-a31b-725b210d98e9"",
                    ""path"": ""<Mouse>/backButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resting Hand Axis 2D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""823b1a5b-780d-4b61-8fd3-cb363e37df26"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resting Hand Axis 2D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ed43b77d-dba1-4b89-a867-d4bb242c19e3"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resting Hand Axis 2D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""38ceacb7-94a0-455f-8b09-eab87cdb5abb"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resting Hand Axis 2D"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0499cb7f-9e2c-4ac7-b2bf-6a71a4457ea1"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resting Hand Axis 2D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b95888ad-1760-4389-8e11-9129f9744211"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resting Hand Axis 2D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fe8ea864-1ec3-4bd6-9c30-854922a9bf73"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resting Hand Axis 2D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d3516be4-3963-4077-82fc-347a180d6949"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resting Hand Axis 2D"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""aac14b93-d556-4433-8893-0eeafd6190f8"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc242731-d17f-4b22-aa06-3988e7cffc87"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b853efd-1a70-4a8b-bd1b-84100070d99c"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86def88d-725b-4541-8677-68ae5946fbd4"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8b72a5c-4ece-44b9-b4a0-a84ce577c393"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""91ad530e-a4db-4a8c-8e21-599db3968011"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary 2D Axis Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1504de2d-a743-4608-a126-5b3ef5695007"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary 2D Axis Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73f9a145-85de-4e35-97d5-824ab21ea67c"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary 2D Axis Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d5d8b6c-3d19-481a-8d8f-9f099a1a43e3"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary 2D Axis Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d431c3c8-2dbc-43fb-9062-1a7e478bbc11"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02d5a7f4-ea4a-465a-8232-b5419ca49f69"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_KeyboardXTranslate = m_Main.FindAction("Keyboard X Translate", throwIfNotFound: true);
        m_Main_KeyboardZTranslate = m_Main.FindAction("Keyboard Z Translate", throwIfNotFound: true);
        m_Main_KeyboardYTranslate = m_Main.FindAction("Keyboard Y Translate", throwIfNotFound: true);
        m_Main_ManipulateLeftHand = m_Main.FindAction("Manipulate LeftHand", throwIfNotFound: true);
        m_Main_ManipulateRightHand = m_Main.FindAction("Manipulate RightHand", throwIfNotFound: true);
        m_Main_ToggleManipulateLeftHand = m_Main.FindAction("Toggle Manipulate LeftHand", throwIfNotFound: true);
        m_Main_ToggleManipulateRightHand = m_Main.FindAction("Toggle Manipulate RightHand", throwIfNotFound: true);
        m_Main_ManipulateHead = m_Main.FindAction("Manipulate Head", throwIfNotFound: true);
        m_Main_MouseDelta = m_Main.FindAction("Mouse Delta", throwIfNotFound: true);
        m_Main_MouseScroll = m_Main.FindAction("Mouse Scroll", throwIfNotFound: true);
        m_Main_RotateModeOverride = m_Main.FindAction("Rotate Mode Override", throwIfNotFound: true);
        m_Main_ToggleMouseTransformationMode = m_Main.FindAction("Toggle Mouse Transformation Mode", throwIfNotFound: true);
        m_Main_NegateMode = m_Main.FindAction("Negate Mode", throwIfNotFound: true);
        m_Main_ZConstraint = m_Main.FindAction("Z Constraint", throwIfNotFound: true);
        m_Main_XConstraint = m_Main.FindAction("X Constraint", throwIfNotFound: true);
        m_Main_YConstraint = m_Main.FindAction("Y Constraint", throwIfNotFound: true);
        m_Main_Reset = m_Main.FindAction("Reset", throwIfNotFound: true);
        m_Main_ToggleCursorLock = m_Main.FindAction("Toggle Cursor Lock", throwIfNotFound: true);
        // Input Controls
        m_InputControls = asset.FindActionMap("Input Controls", throwIfNotFound: true);
        m_InputControls_Axis2D = m_InputControls.FindAction("Axis 2D", throwIfNotFound: true);
        m_InputControls_RestingHandAxis2D = m_InputControls.FindAction("Resting Hand Axis 2D", throwIfNotFound: true);
        m_InputControls_ToggleDevicePositionTarget = m_InputControls.FindAction("Toggle Device Position Target", throwIfNotFound: true);
        m_InputControls_TogglePrimary2DAxisTarget = m_InputControls.FindAction("Toggle Primary 2D Axis Target", throwIfNotFound: true);
        m_InputControls_ToggleSecondary2DAxisTarget = m_InputControls.FindAction("Toggle Secondary 2D Axis Target", throwIfNotFound: true);
        m_InputControls_Grip = m_InputControls.FindAction("Grip", throwIfNotFound: true);
        m_InputControls_Trigger = m_InputControls.FindAction("Trigger", throwIfNotFound: true);
        m_InputControls_PrimaryButton = m_InputControls.FindAction("Primary Button", throwIfNotFound: true);
        m_InputControls_SecondaryButton = m_InputControls.FindAction("Secondary Button", throwIfNotFound: true);
        m_InputControls_Menu = m_InputControls.FindAction("Menu", throwIfNotFound: true);
        m_InputControls_Primary2DAxisClick = m_InputControls.FindAction("Primary 2D Axis Click", throwIfNotFound: true);
        m_InputControls_Secondary2DAxisClick = m_InputControls.FindAction("Secondary 2D Axis Click", throwIfNotFound: true);
        m_InputControls_Primary2DAxisTouch = m_InputControls.FindAction("Primary 2D Axis Touch", throwIfNotFound: true);
        m_InputControls_Secondary2DAxisTouch = m_InputControls.FindAction("Secondary 2D Axis Touch", throwIfNotFound: true);
        m_InputControls_PrimaryTouch = m_InputControls.FindAction("Primary Touch", throwIfNotFound: true);
        m_InputControls_SecondaryTouch = m_InputControls.FindAction("Secondary Touch", throwIfNotFound: true);
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

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_KeyboardXTranslate;
    private readonly InputAction m_Main_KeyboardZTranslate;
    private readonly InputAction m_Main_KeyboardYTranslate;
    private readonly InputAction m_Main_ManipulateLeftHand;
    private readonly InputAction m_Main_ManipulateRightHand;
    private readonly InputAction m_Main_ToggleManipulateLeftHand;
    private readonly InputAction m_Main_ToggleManipulateRightHand;
    private readonly InputAction m_Main_ManipulateHead;
    private readonly InputAction m_Main_MouseDelta;
    private readonly InputAction m_Main_MouseScroll;
    private readonly InputAction m_Main_RotateModeOverride;
    private readonly InputAction m_Main_ToggleMouseTransformationMode;
    private readonly InputAction m_Main_NegateMode;
    private readonly InputAction m_Main_ZConstraint;
    private readonly InputAction m_Main_XConstraint;
    private readonly InputAction m_Main_YConstraint;
    private readonly InputAction m_Main_Reset;
    private readonly InputAction m_Main_ToggleCursorLock;
    public struct MainActions
    {
        private @XRDeviceSimulatorControls m_Wrapper;
        public MainActions(@XRDeviceSimulatorControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @KeyboardXTranslate => m_Wrapper.m_Main_KeyboardXTranslate;
        public InputAction @KeyboardZTranslate => m_Wrapper.m_Main_KeyboardZTranslate;
        public InputAction @KeyboardYTranslate => m_Wrapper.m_Main_KeyboardYTranslate;
        public InputAction @ManipulateLeftHand => m_Wrapper.m_Main_ManipulateLeftHand;
        public InputAction @ManipulateRightHand => m_Wrapper.m_Main_ManipulateRightHand;
        public InputAction @ToggleManipulateLeftHand => m_Wrapper.m_Main_ToggleManipulateLeftHand;
        public InputAction @ToggleManipulateRightHand => m_Wrapper.m_Main_ToggleManipulateRightHand;
        public InputAction @ManipulateHead => m_Wrapper.m_Main_ManipulateHead;
        public InputAction @MouseDelta => m_Wrapper.m_Main_MouseDelta;
        public InputAction @MouseScroll => m_Wrapper.m_Main_MouseScroll;
        public InputAction @RotateModeOverride => m_Wrapper.m_Main_RotateModeOverride;
        public InputAction @ToggleMouseTransformationMode => m_Wrapper.m_Main_ToggleMouseTransformationMode;
        public InputAction @NegateMode => m_Wrapper.m_Main_NegateMode;
        public InputAction @ZConstraint => m_Wrapper.m_Main_ZConstraint;
        public InputAction @XConstraint => m_Wrapper.m_Main_XConstraint;
        public InputAction @YConstraint => m_Wrapper.m_Main_YConstraint;
        public InputAction @Reset => m_Wrapper.m_Main_Reset;
        public InputAction @ToggleCursorLock => m_Wrapper.m_Main_ToggleCursorLock;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @KeyboardXTranslate.started -= m_Wrapper.m_MainActionsCallbackInterface.OnKeyboardXTranslate;
                @KeyboardXTranslate.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnKeyboardXTranslate;
                @KeyboardXTranslate.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnKeyboardXTranslate;
                @KeyboardZTranslate.started -= m_Wrapper.m_MainActionsCallbackInterface.OnKeyboardZTranslate;
                @KeyboardZTranslate.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnKeyboardZTranslate;
                @KeyboardZTranslate.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnKeyboardZTranslate;
                @KeyboardYTranslate.started -= m_Wrapper.m_MainActionsCallbackInterface.OnKeyboardYTranslate;
                @KeyboardYTranslate.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnKeyboardYTranslate;
                @KeyboardYTranslate.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnKeyboardYTranslate;
                @ManipulateLeftHand.started -= m_Wrapper.m_MainActionsCallbackInterface.OnManipulateLeftHand;
                @ManipulateLeftHand.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnManipulateLeftHand;
                @ManipulateLeftHand.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnManipulateLeftHand;
                @ManipulateRightHand.started -= m_Wrapper.m_MainActionsCallbackInterface.OnManipulateRightHand;
                @ManipulateRightHand.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnManipulateRightHand;
                @ManipulateRightHand.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnManipulateRightHand;
                @ToggleManipulateLeftHand.started -= m_Wrapper.m_MainActionsCallbackInterface.OnToggleManipulateLeftHand;
                @ToggleManipulateLeftHand.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnToggleManipulateLeftHand;
                @ToggleManipulateLeftHand.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnToggleManipulateLeftHand;
                @ToggleManipulateRightHand.started -= m_Wrapper.m_MainActionsCallbackInterface.OnToggleManipulateRightHand;
                @ToggleManipulateRightHand.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnToggleManipulateRightHand;
                @ToggleManipulateRightHand.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnToggleManipulateRightHand;
                @ManipulateHead.started -= m_Wrapper.m_MainActionsCallbackInterface.OnManipulateHead;
                @ManipulateHead.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnManipulateHead;
                @ManipulateHead.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnManipulateHead;
                @MouseDelta.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMouseDelta;
                @MouseDelta.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMouseDelta;
                @MouseDelta.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMouseDelta;
                @MouseScroll.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMouseScroll;
                @MouseScroll.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMouseScroll;
                @MouseScroll.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMouseScroll;
                @RotateModeOverride.started -= m_Wrapper.m_MainActionsCallbackInterface.OnRotateModeOverride;
                @RotateModeOverride.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnRotateModeOverride;
                @RotateModeOverride.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnRotateModeOverride;
                @ToggleMouseTransformationMode.started -= m_Wrapper.m_MainActionsCallbackInterface.OnToggleMouseTransformationMode;
                @ToggleMouseTransformationMode.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnToggleMouseTransformationMode;
                @ToggleMouseTransformationMode.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnToggleMouseTransformationMode;
                @NegateMode.started -= m_Wrapper.m_MainActionsCallbackInterface.OnNegateMode;
                @NegateMode.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnNegateMode;
                @NegateMode.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnNegateMode;
                @ZConstraint.started -= m_Wrapper.m_MainActionsCallbackInterface.OnZConstraint;
                @ZConstraint.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnZConstraint;
                @ZConstraint.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnZConstraint;
                @XConstraint.started -= m_Wrapper.m_MainActionsCallbackInterface.OnXConstraint;
                @XConstraint.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnXConstraint;
                @XConstraint.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnXConstraint;
                @YConstraint.started -= m_Wrapper.m_MainActionsCallbackInterface.OnYConstraint;
                @YConstraint.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnYConstraint;
                @YConstraint.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnYConstraint;
                @Reset.started -= m_Wrapper.m_MainActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnReset;
                @ToggleCursorLock.started -= m_Wrapper.m_MainActionsCallbackInterface.OnToggleCursorLock;
                @ToggleCursorLock.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnToggleCursorLock;
                @ToggleCursorLock.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnToggleCursorLock;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @KeyboardXTranslate.started += instance.OnKeyboardXTranslate;
                @KeyboardXTranslate.performed += instance.OnKeyboardXTranslate;
                @KeyboardXTranslate.canceled += instance.OnKeyboardXTranslate;
                @KeyboardZTranslate.started += instance.OnKeyboardZTranslate;
                @KeyboardZTranslate.performed += instance.OnKeyboardZTranslate;
                @KeyboardZTranslate.canceled += instance.OnKeyboardZTranslate;
                @KeyboardYTranslate.started += instance.OnKeyboardYTranslate;
                @KeyboardYTranslate.performed += instance.OnKeyboardYTranslate;
                @KeyboardYTranslate.canceled += instance.OnKeyboardYTranslate;
                @ManipulateLeftHand.started += instance.OnManipulateLeftHand;
                @ManipulateLeftHand.performed += instance.OnManipulateLeftHand;
                @ManipulateLeftHand.canceled += instance.OnManipulateLeftHand;
                @ManipulateRightHand.started += instance.OnManipulateRightHand;
                @ManipulateRightHand.performed += instance.OnManipulateRightHand;
                @ManipulateRightHand.canceled += instance.OnManipulateRightHand;
                @ToggleManipulateLeftHand.started += instance.OnToggleManipulateLeftHand;
                @ToggleManipulateLeftHand.performed += instance.OnToggleManipulateLeftHand;
                @ToggleManipulateLeftHand.canceled += instance.OnToggleManipulateLeftHand;
                @ToggleManipulateRightHand.started += instance.OnToggleManipulateRightHand;
                @ToggleManipulateRightHand.performed += instance.OnToggleManipulateRightHand;
                @ToggleManipulateRightHand.canceled += instance.OnToggleManipulateRightHand;
                @ManipulateHead.started += instance.OnManipulateHead;
                @ManipulateHead.performed += instance.OnManipulateHead;
                @ManipulateHead.canceled += instance.OnManipulateHead;
                @MouseDelta.started += instance.OnMouseDelta;
                @MouseDelta.performed += instance.OnMouseDelta;
                @MouseDelta.canceled += instance.OnMouseDelta;
                @MouseScroll.started += instance.OnMouseScroll;
                @MouseScroll.performed += instance.OnMouseScroll;
                @MouseScroll.canceled += instance.OnMouseScroll;
                @RotateModeOverride.started += instance.OnRotateModeOverride;
                @RotateModeOverride.performed += instance.OnRotateModeOverride;
                @RotateModeOverride.canceled += instance.OnRotateModeOverride;
                @ToggleMouseTransformationMode.started += instance.OnToggleMouseTransformationMode;
                @ToggleMouseTransformationMode.performed += instance.OnToggleMouseTransformationMode;
                @ToggleMouseTransformationMode.canceled += instance.OnToggleMouseTransformationMode;
                @NegateMode.started += instance.OnNegateMode;
                @NegateMode.performed += instance.OnNegateMode;
                @NegateMode.canceled += instance.OnNegateMode;
                @ZConstraint.started += instance.OnZConstraint;
                @ZConstraint.performed += instance.OnZConstraint;
                @ZConstraint.canceled += instance.OnZConstraint;
                @XConstraint.started += instance.OnXConstraint;
                @XConstraint.performed += instance.OnXConstraint;
                @XConstraint.canceled += instance.OnXConstraint;
                @YConstraint.started += instance.OnYConstraint;
                @YConstraint.performed += instance.OnYConstraint;
                @YConstraint.canceled += instance.OnYConstraint;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
                @ToggleCursorLock.started += instance.OnToggleCursorLock;
                @ToggleCursorLock.performed += instance.OnToggleCursorLock;
                @ToggleCursorLock.canceled += instance.OnToggleCursorLock;
            }
        }
    }
    public MainActions @Main => new MainActions(this);

    // Input Controls
    private readonly InputActionMap m_InputControls;
    private IInputControlsActions m_InputControlsActionsCallbackInterface;
    private readonly InputAction m_InputControls_Axis2D;
    private readonly InputAction m_InputControls_RestingHandAxis2D;
    private readonly InputAction m_InputControls_ToggleDevicePositionTarget;
    private readonly InputAction m_InputControls_TogglePrimary2DAxisTarget;
    private readonly InputAction m_InputControls_ToggleSecondary2DAxisTarget;
    private readonly InputAction m_InputControls_Grip;
    private readonly InputAction m_InputControls_Trigger;
    private readonly InputAction m_InputControls_PrimaryButton;
    private readonly InputAction m_InputControls_SecondaryButton;
    private readonly InputAction m_InputControls_Menu;
    private readonly InputAction m_InputControls_Primary2DAxisClick;
    private readonly InputAction m_InputControls_Secondary2DAxisClick;
    private readonly InputAction m_InputControls_Primary2DAxisTouch;
    private readonly InputAction m_InputControls_Secondary2DAxisTouch;
    private readonly InputAction m_InputControls_PrimaryTouch;
    private readonly InputAction m_InputControls_SecondaryTouch;
    public struct InputControlsActions
    {
        private @XRDeviceSimulatorControls m_Wrapper;
        public InputControlsActions(@XRDeviceSimulatorControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Axis2D => m_Wrapper.m_InputControls_Axis2D;
        public InputAction @RestingHandAxis2D => m_Wrapper.m_InputControls_RestingHandAxis2D;
        public InputAction @ToggleDevicePositionTarget => m_Wrapper.m_InputControls_ToggleDevicePositionTarget;
        public InputAction @TogglePrimary2DAxisTarget => m_Wrapper.m_InputControls_TogglePrimary2DAxisTarget;
        public InputAction @ToggleSecondary2DAxisTarget => m_Wrapper.m_InputControls_ToggleSecondary2DAxisTarget;
        public InputAction @Grip => m_Wrapper.m_InputControls_Grip;
        public InputAction @Trigger => m_Wrapper.m_InputControls_Trigger;
        public InputAction @PrimaryButton => m_Wrapper.m_InputControls_PrimaryButton;
        public InputAction @SecondaryButton => m_Wrapper.m_InputControls_SecondaryButton;
        public InputAction @Menu => m_Wrapper.m_InputControls_Menu;
        public InputAction @Primary2DAxisClick => m_Wrapper.m_InputControls_Primary2DAxisClick;
        public InputAction @Secondary2DAxisClick => m_Wrapper.m_InputControls_Secondary2DAxisClick;
        public InputAction @Primary2DAxisTouch => m_Wrapper.m_InputControls_Primary2DAxisTouch;
        public InputAction @Secondary2DAxisTouch => m_Wrapper.m_InputControls_Secondary2DAxisTouch;
        public InputAction @PrimaryTouch => m_Wrapper.m_InputControls_PrimaryTouch;
        public InputAction @SecondaryTouch => m_Wrapper.m_InputControls_SecondaryTouch;
        public InputActionMap Get() { return m_Wrapper.m_InputControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InputControlsActions set) { return set.Get(); }
        public void SetCallbacks(IInputControlsActions instance)
        {
            if (m_Wrapper.m_InputControlsActionsCallbackInterface != null)
            {
                @Axis2D.started -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnAxis2D;
                @Axis2D.performed -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnAxis2D;
                @Axis2D.canceled -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnAxis2D;
                @RestingHandAxis2D.started -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnRestingHandAxis2D;
                @RestingHandAxis2D.performed -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnRestingHandAxis2D;
                @RestingHandAxis2D.canceled -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnRestingHandAxis2D;
                @ToggleDevicePositionTarget.started -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnToggleDevicePositionTarget;
                @ToggleDevicePositionTarget.performed -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnToggleDevicePositionTarget;
                @ToggleDevicePositionTarget.canceled -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnToggleDevicePositionTarget;
                @TogglePrimary2DAxisTarget.started -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnTogglePrimary2DAxisTarget;
                @TogglePrimary2DAxisTarget.performed -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnTogglePrimary2DAxisTarget;
                @TogglePrimary2DAxisTarget.canceled -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnTogglePrimary2DAxisTarget;
                @ToggleSecondary2DAxisTarget.started -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnToggleSecondary2DAxisTarget;
                @ToggleSecondary2DAxisTarget.performed -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnToggleSecondary2DAxisTarget;
                @ToggleSecondary2DAxisTarget.canceled -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnToggleSecondary2DAxisTarget;
                @Grip.started -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnGrip;
                @Grip.performed -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnGrip;
                @Grip.canceled -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnGrip;
                @Trigger.started -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnTrigger;
                @Trigger.performed -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnTrigger;
                @Trigger.canceled -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnTrigger;
                @PrimaryButton.started -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnPrimaryButton;
                @PrimaryButton.performed -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnPrimaryButton;
                @PrimaryButton.canceled -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnPrimaryButton;
                @SecondaryButton.started -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnSecondaryButton;
                @SecondaryButton.performed -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnSecondaryButton;
                @SecondaryButton.canceled -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnSecondaryButton;
                @Menu.started -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnMenu;
                @Primary2DAxisClick.started -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnPrimary2DAxisClick;
                @Primary2DAxisClick.performed -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnPrimary2DAxisClick;
                @Primary2DAxisClick.canceled -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnPrimary2DAxisClick;
                @Secondary2DAxisClick.started -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnSecondary2DAxisClick;
                @Secondary2DAxisClick.performed -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnSecondary2DAxisClick;
                @Secondary2DAxisClick.canceled -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnSecondary2DAxisClick;
                @Primary2DAxisTouch.started -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnPrimary2DAxisTouch;
                @Primary2DAxisTouch.performed -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnPrimary2DAxisTouch;
                @Primary2DAxisTouch.canceled -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnPrimary2DAxisTouch;
                @Secondary2DAxisTouch.started -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnSecondary2DAxisTouch;
                @Secondary2DAxisTouch.performed -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnSecondary2DAxisTouch;
                @Secondary2DAxisTouch.canceled -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnSecondary2DAxisTouch;
                @PrimaryTouch.started -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnPrimaryTouch;
                @PrimaryTouch.performed -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnPrimaryTouch;
                @PrimaryTouch.canceled -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnPrimaryTouch;
                @SecondaryTouch.started -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnSecondaryTouch;
                @SecondaryTouch.performed -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnSecondaryTouch;
                @SecondaryTouch.canceled -= m_Wrapper.m_InputControlsActionsCallbackInterface.OnSecondaryTouch;
            }
            m_Wrapper.m_InputControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Axis2D.started += instance.OnAxis2D;
                @Axis2D.performed += instance.OnAxis2D;
                @Axis2D.canceled += instance.OnAxis2D;
                @RestingHandAxis2D.started += instance.OnRestingHandAxis2D;
                @RestingHandAxis2D.performed += instance.OnRestingHandAxis2D;
                @RestingHandAxis2D.canceled += instance.OnRestingHandAxis2D;
                @ToggleDevicePositionTarget.started += instance.OnToggleDevicePositionTarget;
                @ToggleDevicePositionTarget.performed += instance.OnToggleDevicePositionTarget;
                @ToggleDevicePositionTarget.canceled += instance.OnToggleDevicePositionTarget;
                @TogglePrimary2DAxisTarget.started += instance.OnTogglePrimary2DAxisTarget;
                @TogglePrimary2DAxisTarget.performed += instance.OnTogglePrimary2DAxisTarget;
                @TogglePrimary2DAxisTarget.canceled += instance.OnTogglePrimary2DAxisTarget;
                @ToggleSecondary2DAxisTarget.started += instance.OnToggleSecondary2DAxisTarget;
                @ToggleSecondary2DAxisTarget.performed += instance.OnToggleSecondary2DAxisTarget;
                @ToggleSecondary2DAxisTarget.canceled += instance.OnToggleSecondary2DAxisTarget;
                @Grip.started += instance.OnGrip;
                @Grip.performed += instance.OnGrip;
                @Grip.canceled += instance.OnGrip;
                @Trigger.started += instance.OnTrigger;
                @Trigger.performed += instance.OnTrigger;
                @Trigger.canceled += instance.OnTrigger;
                @PrimaryButton.started += instance.OnPrimaryButton;
                @PrimaryButton.performed += instance.OnPrimaryButton;
                @PrimaryButton.canceled += instance.OnPrimaryButton;
                @SecondaryButton.started += instance.OnSecondaryButton;
                @SecondaryButton.performed += instance.OnSecondaryButton;
                @SecondaryButton.canceled += instance.OnSecondaryButton;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @Primary2DAxisClick.started += instance.OnPrimary2DAxisClick;
                @Primary2DAxisClick.performed += instance.OnPrimary2DAxisClick;
                @Primary2DAxisClick.canceled += instance.OnPrimary2DAxisClick;
                @Secondary2DAxisClick.started += instance.OnSecondary2DAxisClick;
                @Secondary2DAxisClick.performed += instance.OnSecondary2DAxisClick;
                @Secondary2DAxisClick.canceled += instance.OnSecondary2DAxisClick;
                @Primary2DAxisTouch.started += instance.OnPrimary2DAxisTouch;
                @Primary2DAxisTouch.performed += instance.OnPrimary2DAxisTouch;
                @Primary2DAxisTouch.canceled += instance.OnPrimary2DAxisTouch;
                @Secondary2DAxisTouch.started += instance.OnSecondary2DAxisTouch;
                @Secondary2DAxisTouch.performed += instance.OnSecondary2DAxisTouch;
                @Secondary2DAxisTouch.canceled += instance.OnSecondary2DAxisTouch;
                @PrimaryTouch.started += instance.OnPrimaryTouch;
                @PrimaryTouch.performed += instance.OnPrimaryTouch;
                @PrimaryTouch.canceled += instance.OnPrimaryTouch;
                @SecondaryTouch.started += instance.OnSecondaryTouch;
                @SecondaryTouch.performed += instance.OnSecondaryTouch;
                @SecondaryTouch.canceled += instance.OnSecondaryTouch;
            }
        }
    }
    public InputControlsActions @InputControls => new InputControlsActions(this);
    public interface IMainActions
    {
        void OnKeyboardXTranslate(InputAction.CallbackContext context);
        void OnKeyboardZTranslate(InputAction.CallbackContext context);
        void OnKeyboardYTranslate(InputAction.CallbackContext context);
        void OnManipulateLeftHand(InputAction.CallbackContext context);
        void OnManipulateRightHand(InputAction.CallbackContext context);
        void OnToggleManipulateLeftHand(InputAction.CallbackContext context);
        void OnToggleManipulateRightHand(InputAction.CallbackContext context);
        void OnManipulateHead(InputAction.CallbackContext context);
        void OnMouseDelta(InputAction.CallbackContext context);
        void OnMouseScroll(InputAction.CallbackContext context);
        void OnRotateModeOverride(InputAction.CallbackContext context);
        void OnToggleMouseTransformationMode(InputAction.CallbackContext context);
        void OnNegateMode(InputAction.CallbackContext context);
        void OnZConstraint(InputAction.CallbackContext context);
        void OnXConstraint(InputAction.CallbackContext context);
        void OnYConstraint(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnToggleCursorLock(InputAction.CallbackContext context);
    }
    public interface IInputControlsActions
    {
        void OnAxis2D(InputAction.CallbackContext context);
        void OnRestingHandAxis2D(InputAction.CallbackContext context);
        void OnToggleDevicePositionTarget(InputAction.CallbackContext context);
        void OnTogglePrimary2DAxisTarget(InputAction.CallbackContext context);
        void OnToggleSecondary2DAxisTarget(InputAction.CallbackContext context);
        void OnGrip(InputAction.CallbackContext context);
        void OnTrigger(InputAction.CallbackContext context);
        void OnPrimaryButton(InputAction.CallbackContext context);
        void OnSecondaryButton(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnPrimary2DAxisClick(InputAction.CallbackContext context);
        void OnSecondary2DAxisClick(InputAction.CallbackContext context);
        void OnPrimary2DAxisTouch(InputAction.CallbackContext context);
        void OnSecondary2DAxisTouch(InputAction.CallbackContext context);
        void OnPrimaryTouch(InputAction.CallbackContext context);
        void OnSecondaryTouch(InputAction.CallbackContext context);
    }
}
