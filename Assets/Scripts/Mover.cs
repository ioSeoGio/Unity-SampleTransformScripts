using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _maxDistance;

    private Vector3 _initialPosition;
    private Vector3 _currentDirection;

    private void Start()
    {
        _initialPosition = this.transform.position;
        _currentDirection = transform.forward;
    }

    private void FixedUpdate()
    {
        transform.Translate(Math.Abs(_speed) * Time.deltaTime * _currentDirection);

        if (Vector3Extensions.IsOutOfRange(transform.position, _initialPosition, _maxDistance))
        {
            _currentDirection *= -1;
        }
    }
}