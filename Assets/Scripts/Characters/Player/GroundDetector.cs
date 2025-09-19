using System;
using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private float _checkRadius;
    [SerializeField] private LayerMask _whatIsGround;

    public event Action GroundDetected;
    public bool IsGrounded { get; private set; }

    private void Update()
    {
        Check();
    }

    private void Check()
    {
        Collider2D hit = Physics2D.OverlapCircle(_groundCheck.position, _checkRadius, _whatIsGround);

        if (hit != null)
        {
            IsGrounded = true;
        }
        else
        {
            IsGrounded = false;
            GroundDetected?.Invoke();
        }
    }
}