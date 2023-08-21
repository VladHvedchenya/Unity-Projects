using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public void Move(EnemyTarget target, float speed)
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
}