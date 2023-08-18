using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(new Vector3(_speed * Time.deltaTime, 0, 0));
    }
}
