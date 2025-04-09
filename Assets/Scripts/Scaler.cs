using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _maxScale;

    private Vector3 _initialScale;
    private Vector3 _currentDirection;

    private void Start()
    {
        _initialScale = transform.lossyScale;
        _currentDirection = new Vector3(1, 1, 1);
    }

    private void FixedUpdate()
    {
        transform.localScale += Math.Abs(_speed) * Time.deltaTime * _currentDirection;

        if (Vector3Extensions.IsOutOfRange(transform.localScale, _initialScale, _maxScale))
        {
            _currentDirection *= -1;
        }
    }
}