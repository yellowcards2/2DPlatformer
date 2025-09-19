using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Mover : MonoBehaviour
{
    [Range(0f, 6f)] [SerializeField] private float _speed = 3f;
    [Range(2f, 10f)][SerializeField] private float _jumpForce = 7f;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        _rigidbody.linearVelocity = new Vector2(_rigidbody.linearVelocity.x, 0);
        _rigidbody.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse);
    }

    public void Move(float direction)
    {
        _rigidbody.linearVelocity = new Vector2(_speed * direction , _rigidbody.linearVelocityY);
    }
}
