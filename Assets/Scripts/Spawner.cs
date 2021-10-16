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

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Vector2 spawnPosition = _spawner.position + new Vector3(0, Random.Range(-_range.y, _range.y));
            Instantiate(_enemyTeaplate, spawnPosition, Quaternion.identity);
        }
    }
    
}
