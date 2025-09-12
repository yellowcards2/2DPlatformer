using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private float _radius;
    [SerializeField] private LayerMask _groundMask;

    public bool Check()
    {
        Collider2D cirleCollider = Physics2D.OverlapCircle(_groundCheck.position, _radius, _groundMask);

        if (cirleCollider != null)
        {
            return true;
        }

        return false;
    }
}
