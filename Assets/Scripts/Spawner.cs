using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _spawner;
    [SerializeField] private Vector2 _range;
    [SerializeField] private Enemy _enemyTeaplate;
    [SerializeField] private Bonus _bonusTeaplate;


    private void Start()
    {
        StartCoroutine(SpawnEnemy());
        StartCoroutine(SpawnBonus());
    }

    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Vector2 spawnPosition = _spawner.position + new Vector3(0, Random.Range(-_range.y, _range.y));
            Instantiate(_enemyTeaplate, spawnPosition, Quaternion.identity);
        }
    }

    IEnumerator SpawnBonus()
    {
        while (true)
        {
            yield return new WaitForSeconds(3.5f);
            Vector2 spawnPosition = _spawner.position + new Vector3(0, Random.Range(-_range.y, _range.y));
            Instantiate(_bonusTeaplate, spawnPosition, Quaternion.identity);
        }
    }
    
}
