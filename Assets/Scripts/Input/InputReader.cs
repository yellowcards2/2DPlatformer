using UnityEngine;

public class InputReader : MonoBehaviour
{
    private const string Horizontal = "Horizontal";

    private bool _isJumpHolding;

    public float Direction { get; private set; }

    private void Update()
    {
        Direction = Input.GetAxis(Horizontal);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _isJumpHolding = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            _isJumpHolding = false;
        }
    }

    public bool ResetJump()
    {
        return _isJumpHolding;
    }
}
