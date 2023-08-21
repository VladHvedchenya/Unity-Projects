using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _points;
    [SerializeField] private Enemy[] _enemyPrefabs;
    [SerializeField] private EnemyTarget[] _targets;
    [SerializeField] private float _delay;
    
    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        var wait = new WaitForSeconds(_delay);

        while (enabled)
        {
            int randomIndex = Random.Range(0, _points.Length);
            var enemy = Instantiate(_enemyPrefabs[randomIndex], _points[randomIndex].transform.position, Quaternion.identity);
            enemy.SetTarget(_targets[randomIndex]);
            yield return wait;
        }
    }
}
