using System;
using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Player : MonoBehaviour
{
    [SerializeField] private Animation _animation;

    private InputReader _inputReader;
    private Mover _mover;
    private GroundDetector _groundDetector;
    private Flipper _fllipper;
    private int _coin;

    public delegate void CoinPickedDelegate(int coins);
    public event CoinPickedDelegate CoinPicked;

    private void Awake()
    {
        _inputReader = GetComponent<InputReader>();
        _mover = GetComponent<Mover>();
        _groundDetector = GetComponent<GroundDetector>();
        _fllipper = GetComponent<Flipper>();
    }

    private void Update()
    {
        if (_inputReader.Direction != 0)
        {
            _mover.Move(_inputReader.Direction);
        }

        if (_inputReader.ResetJump() && _groundDetector.IsGrounded)
        {
            _mover.Jump();
        }

        _animation.SetAnimationRun(_inputReader.Direction);
        _fllipper.Flip(_inputReader.Direction);
    }

    public void InrementCoin()
    {
        _coin++;
        CoinPicked?.Invoke(_coin);
    }
}
