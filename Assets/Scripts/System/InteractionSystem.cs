using UnityEngine;

public class InteractionSystem : MonoBehaviour, IService
{
    private IInteractable _currentInteractable;

    public void Init()
    {
        Debug.Log("InteractionSystem Init called");
    }

    public void SetInteractbale(IInteractable interactable)
    {
        _currentInteractable = interactable;
    }

    public void ClearInteractbale()
    {
        _currentInteractable = null;
    }

    public void TryInteract()
    {
        if (_currentInteractable == null)
        {
            return;
        }
        
        _currentInteractable.Interact();
    }

    public InteractionType? GetCurrentInteractionType()
    {
        if (_currentInteractable == null)
        {
            return null;
        }
        
        return _currentInteractable.InteractionType;
    }
    
    
    
}
