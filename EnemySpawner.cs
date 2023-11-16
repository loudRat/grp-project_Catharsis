using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private float SpawnRadius = 7, time = 10f;

    public GameObject[] enemies;
    void Start()
    {
        StartCoroutine(SpawnEnememy());
    }

    IEnumerator SpawnEnememy()
    {
        Vector2 spawnPos = GameObject.Find("Player").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * SpawnRadius;

        Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, Quaternion.identity);
        yield return new WaitForSeconds(time);
        StartCoroutine(SpawnEnememy());
    }
}
