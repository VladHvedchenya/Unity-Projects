using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public void Move(Vector3 direction, float speed)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
