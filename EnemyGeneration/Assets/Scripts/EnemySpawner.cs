using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _points;
    [SerializeField] private Enemy _prefab;
    [SerializeField] private Vector3 _enemyDirection;
    
    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var wait = new WaitForSeconds(2f);

        while (enabled)
        {
            int randomIndex = Random.Range(0, _points.Length);
            var enemy = Instantiate(_prefab, _points[randomIndex].transform.position, Quaternion.identity);
            enemy.SetDirection(_enemyDirection);
            yield return wait;
        }
    }
}
