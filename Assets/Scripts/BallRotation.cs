using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _centreCircle;
    
    private void Awake()
    {
        _centreCircle = GetComponent<Transform>();
    }

    private void Update()
    {
        MoveBall();
        ChangeDirection();
    }

    private void MoveBall()
    {
        _centreCircle.Rotate(0,0, _speed * Time.deltaTime);
    }

    private void ChangeDirection()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _speed = -_speed;
        }
    }
    
}
