using UnityEngine;

public class Flipper : MonoBehaviour
{
    private const float RightSide = 0f;
    private const float LeftSide = 180f;

    [SerializeField] private Transform _transform;

    public void Flip(float horizontalMove)
    {
        if (horizontalMove < 0)
        {
            _transform.rotation = Quaternion.Euler(0, LeftSide, 0);
        }
        else if (horizontalMove > 0)
        {
            _transform.rotation = Quaternion.Euler(0, RightSide, 0);
        }  
    }
}
