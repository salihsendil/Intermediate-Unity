using System;
using UnityEngine;

public class Cube : MonoBehaviour, IClickable
{
    private Vector3 _targetPos;
    private float _speed = 10f;

    void Start()
    {
        _targetPos = transform.position;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, _targetPos) < 0.05f)
        {
            transform.position = _targetPos;
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, _targetPos, Time.deltaTime * _speed);
        }
    }

    public void Click(object sender, EventArgs e)
    {
        float _newX = transform.position.x * -1;
        _targetPos = new Vector3(_newX, transform.position.y, transform.position.z);

    }
}