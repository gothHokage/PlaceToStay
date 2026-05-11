using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputManager : MonoBehaviour, IService
{
    private InputSystem _playerInput;
    
    public Vector2 MoveDirection { get; private set; }
    public bool MenuPressed { get; private set;}
    public bool InventoryPressed { get; private set; }
    public bool InteractPressed {get; private set;}
    
    public void Init()
    {
        _playerInput = new InputSystem();
        _playerInput.Player.Enable();

        _playerInput.Player.Move.performed += OnMove;
        _playerInput.Player.Move.canceled += OnMoveStop;

        _playerInput.Player.Interact.performed += OnInteract;
        _playerInput.Player.Interact.canceled += OnInteractStop;

        _playerInput.Player.Menu.performed += OnMenu;
        _playerInput.Player.Inventory.performed += OnInventory;
        
      
        
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


    private void OnInteract(InputAction.CallbackContext ctx)
    {
        InteractPressed = true;   
    }

    private void OnInteractStop(InputAction.CallbackContext ctx)
    {
        InteractPressed = false;
    }

    private void OnMenu(InputAction.CallbackContext ctx)
    {
        MenuPressed = true;
    }

    private void OnInventory(InputAction.CallbackContext ctx)
    {
        InventoryPressed = true;
    }
    
    
}
