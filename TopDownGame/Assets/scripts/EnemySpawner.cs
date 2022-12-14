using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float spawnRadius, time;

    public GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnAnEnemy());
    }

    IEnumerator SpawnAnEnemy()
    {
        Vector2 spawnPos = GameObject.Find("Car").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;

        Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, Quaternion.identity);

        yield return new WaitForSeconds(time);
        StartCoroutine(SpawnAnEnemy());
    }
}
