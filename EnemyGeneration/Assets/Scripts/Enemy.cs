using UnityEngine;

[RequireComponent(typeof(EnemyMover))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _direction;
    private EnemyMover _mover;
    
    private void Start()
    {
        _mover = GetComponent<EnemyMover>();
    }
    
    private void Update()
    {  
        _mover.Move(_direction, _speed);
    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }
}
