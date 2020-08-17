using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    #region Fields

    [SerializeField] private float _speed;
    [SerializeField] private float _lifeTime;

    private Rigidbody _rigidbody;

    #endregion Fields

    #region UnityMethods

    private void Start()
    {
        Destroy(gameObject, _lifeTime);
        _rigidbody = GetComponent<Rigidbody>();

        var impuls = transform.up * _rigidbody.mass * _speed;

        _rigidbody.AddForce(impuls, ForceMode.Impulse);
    }

    #endregion UnityMethods
}
