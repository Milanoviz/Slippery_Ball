using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Enemy _enemy;


    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    { 
        _enemy.transform.Translate(_speed * Time.deltaTime, 0, 0);
    }
}
