using UnityEngine;

public class CameraConroller : MonoBehaviour
{
    [SerializeField] private Transform _player;

    private Vector3 _position;
    private float _cameraVisibleValue = -7f;

    private void Start()
    {
        if (!_player)
        {
            _player = FindAnyObjectByType<Player>().transform;
        }
    }

    private void Update()
    {
        _position = _player.position;
        _position.z = _cameraVisibleValue;

        transform.position = Vector3.Lerp(transform.position, _position, Time.deltaTime);
    }
}
