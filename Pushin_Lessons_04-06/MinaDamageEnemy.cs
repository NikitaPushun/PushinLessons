using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MinaDamageEnemy : MonoBehaviour
{
    #region Fields

    [SerializeField] private int _damage;
    [SerializeField] GameObject _particleSystem;

    #endregion

    #region UnityMethods

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {            
            var enemy = other.GetComponent<EnemyHealth>();
            enemy.Hurt(_damage);
            Instantiate(_particleSystem, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    #endregion

}
