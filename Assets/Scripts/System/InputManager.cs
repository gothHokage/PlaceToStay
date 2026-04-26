using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputManager : MonoBehaviour, IService
{
    private InputSystem _playerInput;
    
    public Vector2 MoveDirection { get; private set; }
    public bool MenuPressed { get; private set;}
    public bool InventoryPressed { get; private set; }
    public bool UseToolPressed {get; private set;}
    public void Init()
    {
        _playerInput = new InputSystem();
        _playerInput.Player.Enable();

        _playerInput.Player.Move.performed += OnMove;
        _playerInput.Player.Move.canceled += OnMoveStop;
        
        
        Debug.Log("InputSystem init called");
    }

    private void OnMove(InputAction.CallbackContext ctx)
    {
        MoveDirection = ctx.ReadValue<Vector2>();
    }

    private void OnMoveStop(InputAction.CallbackContext ctx)
    {
        MoveDirection = Vector2.zero;
    }
    
}
