using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootingPlayer : MonoBehaviour
{
    #region

    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _spawnPointBullet;
    [SerializeField] private AudioSource _fireSound;

    #endregion

    #region

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot();
            _fireSound.Play();            
        }        
    }      

    private void Shoot()
    {
        Instantiate(_bullet, _spawnPointBullet.position, _spawnPointBullet.rotation);
    }

    #endregion
}


