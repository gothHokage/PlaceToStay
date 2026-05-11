using UnityEngine;

public enum InteractionType
{
    Use,
    Talk,
    Examine
}

public interface IInteractable
{
    InteractionType InteractionType { get; }
    void Interact();
}