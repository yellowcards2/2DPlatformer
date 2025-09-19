using UnityEngine;

public class EnemyPatroller : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] float _distanceToTarget = 0.2f;

    private int _index;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _waypoints[_index].position, _speed * Time.deltaTime);

        if (transform.position.IsEnoughClose(_waypoints[_index].position, _distanceToTarget))
        {
            if (_index > 0)
            {                
                _index = 0;
            }
            else
            {
                _index = 1;
            }
        }
    }
}
