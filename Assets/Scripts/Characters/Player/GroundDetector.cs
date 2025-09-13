using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    private int _collisionCount;

    public bool IsGrounded { get; private set; }

    private void Awake()
    {
        _collisionCount = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Ground>(out _))
        {
            IsGrounded = true;
            _collisionCount++;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Ground>(out _))
        {
            _collisionCount--;
            IsGrounded = _collisionCount > 0;
        }
    }
}
