using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Bonus _bonus;


    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    { 
        _bonus.transform.Translate(_speed * Time.deltaTime, 0, 0);
    }
}
