using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _points;
    [SerializeField] private Enemy _prefab;
    
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
            Instantiate(_prefab, new Vector3(_points[randomIndex].transform.position.x, _points[randomIndex].transform.position.y, _points[randomIndex].transform.position.z), Quaternion.identity);
            yield return wait;
        }
    }
}
