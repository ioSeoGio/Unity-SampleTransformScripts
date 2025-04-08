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

    void Update()
    {
        transform.localScale += Math.Abs(_speed) * Time.deltaTime * _currentDirection;

        if (Vector3.Distance(transform.localScale, _initialScale) > _maxScale)
        {
            Vector3 newDirection = (transform.localScale - _initialScale).normalized;
            newDirection.Scale(new Vector3(-1, -1, -1));

            _currentDirection = newDirection;
        }
    }
}