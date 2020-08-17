using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemonControll : MonoBehaviour
{
    #region Fields

    [SerializeField] private float _speed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private bool _isJumpPressed = false;

    private Vector3 _direction;
    private Rigidbody _rigidbody;

    #endregion


    #region UnityMethods

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MoverPlayer();
        JumpPlayer();                        
    }

    #endregion


    #region Methods

    private void MoverPlayer()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
        _direction = _direction.normalized;

        //var moveVector = _direction * _speed * Time.deltaTime;
        //_rigidbody.velocity = new Vector3(moveVector.x, _rigidbody.velocity.y, moveVector.z);

        var speed = (_direction.sqrMagnitude > 0) ? _speed : 0f;
        speed = speed * Time.deltaTime;
        transform.position += transform.forward * speed;

        Vector3 desiredForward = Vector3.RotateTowards(transform.forward, _direction, _rotateSpeed * Time.deltaTime, 0f);
        transform.rotation = Quaternion.LookRotation(desiredForward);
    }

    private void JumpPlayer()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !_isJumpPressed)
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            //_rigidbody.AddForce(0.0f, _jumpForce, 0.0f);
        }
    }   

    #endregion

}
