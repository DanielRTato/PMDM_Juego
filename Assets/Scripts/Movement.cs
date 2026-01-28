using UnityEngine;
using UnityEngine.InputSystem;  // 1. The Input System "using" statement

public class Movement : MonoBehaviour
{
    InputAction moveAction;
    InputAction jumpAction;

    private void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    void Update()
    {
      

        Vector2 moveValue = moveAction.ReadValue<Vector2>();
        // your movement code here

        if (jumpAction.IsPressed())
        {
            // your jump code here
        }
    }
}
