using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemonControll : MonoBehaviour
{

    [SerializeField] private float _speed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private Vector3 _direction;

    private void FixedUpdate()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
    }

    private void Update()
    {
        var speed = _direction * _speed * Time.deltaTime;
        transform.Translate(speed);
    }

    
}
