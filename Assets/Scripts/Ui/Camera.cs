using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform _player;

    private void LateUpdate()
    {
        transform.position = new Vector3(_player.position.x, _player.position.y, transform.position.z);
    }
}
