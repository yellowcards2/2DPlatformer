using UnityEngine;

public class EnemyPatroller : MonoBehaviour
{
    [SerializeField] private float _speed = 2f;
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private Transform _player;

    private int _index;
    private float _distanceValue = 0.2f;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _waypoints[_index].position, _speed * Time.deltaTime);

        if (Vector2.Distance(transform.position ,_waypoints[_index].position) < _distanceValue)
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
