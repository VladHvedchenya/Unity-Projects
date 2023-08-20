using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _path;
    [SerializeField] private int _currentWayPointIndex;
    
    private Transform[] _wayPoints;

    private void Start()
    {
        _wayPoints = new Transform[_path.childCount];

        for (int i = 0; i < _wayPoints.Length; i++)
        {
            _wayPoints[i] = _path.GetChild(i);
        }
    }

    private void Update()
    {
        Transform currentTarget = _wayPoints[_currentWayPointIndex];

        transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, _speed * Time.deltaTime);
        
        if(currentTarget.position == transform.position)
        {
            _currentWayPointIndex++;

            if (_currentWayPointIndex >= _wayPoints.Length)
                _currentWayPointIndex = 0;
        }
    }
}