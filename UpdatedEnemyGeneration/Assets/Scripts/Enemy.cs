using UnityEngine;

[RequireComponent(typeof(EnemyMover))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private EnemyTarget _target;
    private EnemyMover _mover;

    private void Start()
    {
        _mover = GetComponent<EnemyMover>();
    }

    private void Update()
    {
        _mover.Move(_target, _speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out EnemyTarget target) && target == _target)
            Destroy(gameObject);
    }

    public void SetTarget(EnemyTarget target)
    {
        _target = target;
    }
}