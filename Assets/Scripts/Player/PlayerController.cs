using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    
    private Rigidbody2D _rb;
    private Animator _anim;
    private Vector2 _lastDirection = Vector2.down;
    
    
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Vector2 move = G.InputManager.MoveDirection;
        _rb.linearVelocity = move * _speed;
        
        Animation(move);
        
    }

    private void Animation(Vector2 move)
    {
        if (move != Vector2.zero)
        {
            _lastDirection = move;
            _anim.SetFloat("MoveX", move.x);
            _anim.SetFloat("MoveY", move.y);
            _anim.SetBool("IsMove", true);
        }

        else
        {
            _anim.SetFloat("MoveX", _lastDirection.x);
            _anim.SetFloat("MoveY", _lastDirection.y);
            _anim.SetBool("IsMove", false);
        }
    }

}
