using UnityEngine;

[RequireComponent(typeof(UnityEngine.Animator))]
public class Animation : MonoBehaviour
{
    private readonly int Speed = Animator.StringToHash("Speed");

    private Animator _animator;
     
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void SetAnimationRun(float moveInput)
    {
        _animator.SetFloat(Speed, Mathf.Abs(moveInput));
    }
}
