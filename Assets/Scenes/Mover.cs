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

    void Update()
    {
        transform.Translate(Math.Abs(_speed) * Time.deltaTime * _currentDirection);

        if (Vector3.Distance(transform.position, _initialPosition) > _maxDistance)
        {
            Vector3 newDirection = (transform.position - _initialPosition).normalized;
            newDirection.Scale(new Vector3(-1, -1, -1));
            _currentDirection = newDirection;
        }
    }
}