using UnityEngine;
using UnityEngine.InputSystem;

public class DeviceInput : MonoBehaviour
{
    private InputAction CreateCandyAction;
    private InputAction inputVector2Action;

    public CreateCandy CreateCandy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreateCandyAction = InputSystem.actions.FindAction("CreateCandy");
        inputVector2Action = InputSystem.actions.FindAction("ValueTest");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(inputVector2Action.ReadValue<Vector2>());

        if(CreateCandyAction.WasPressedThisFrame())
        {
            CreateCandy.AddCandy();
        }
    }
}
