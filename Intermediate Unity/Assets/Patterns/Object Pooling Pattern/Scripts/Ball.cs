using System;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody _rb;
    private float _speed = 10f;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        transform.position = Vector3.zero;
        _rb.AddForce(Vector3.up * _speed, ForceMode.Impulse);
    }

    void Update()
    {

    }
}
