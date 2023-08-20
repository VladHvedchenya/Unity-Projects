using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public void Move(EnemyTarget target, float speed)
    {
        transform.Translate((target.transform.position - transform.position) * speed * Time.deltaTime, target.transform);
    }
}
