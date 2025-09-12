using UnityEngine;

public class Flipper : MonoBehaviour
{
    [SerializeField] private Transform _sprite;

    private const float RightSide = 0f;
    private const float LeftSide = 180f;

    public void Flip(float horizontalMove)
    {
        if (horizontalMove < 0)
        {
            _sprite.rotation = Quaternion.Euler(0, LeftSide, 0);
        }
        else if (horizontalMove > 0)
        {
            _sprite.rotation = Quaternion.Euler(0, RightSide, 0);
        }  
    }

    public void FlipToTarget(Vector2 targetPosition)
    {
        float direction = targetPosition.x - transform.position.x;
        Flip(direction);
    }

}
