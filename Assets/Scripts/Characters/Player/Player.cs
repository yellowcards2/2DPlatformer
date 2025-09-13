using System;
using UnityEditor.Tilemaps;
using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Player : MonoBehaviour
{
    [SerializeField] private Animation _animation;

    private const string Horizontal = "Horizontal";

    private Mover _mover;
    private GroundDetector _groundDetector;
    private Flipper _fllipper;
    private int _coin;


    public delegate void CoinPickedDelegate(int coins);
    public event CoinPickedDelegate onCoinPicked;

    public float Direction { get; private set; }

    private void Awake()
    {
        _mover = GetComponent<Mover>();
        _groundDetector = GetComponent<GroundDetector>();
        _fllipper = GetComponent<Flipper>();
    }

    private void Update()
    {
        Direction = Input.GetAxisRaw(Horizontal);

        _mover.Move(Direction);

        if (Input.GetKeyDown(KeyCode.Space) && _groundDetector.IsGrounded)
        {
            _mover.Jump();
        }

        _animation.SetAnimationRun(Direction);

        if (Direction < 0)
        {
            _fllipper.Flip(Direction);
        }
        else if (Direction > 0)
        {
            _fllipper.Flip(Direction);
        }
    }

    public void InrementCoin()
    {
        _coin++;

        onCoinPicked?.Invoke(_coin);
        
    }
}
