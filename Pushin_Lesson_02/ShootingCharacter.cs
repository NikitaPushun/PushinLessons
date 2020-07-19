using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingCharacter : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _spawnPointBullet;
    [SerializeField] private AudioSource _fireSound;
    
    
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot();
            _fireSound.Play();
            //GetComponent<AudioSource>().PlayOneShot(_fireSound);
        }        
    }
       

    private void Shoot()
    {
        Instantiate(_bullet, _spawnPointBullet.position, _spawnPointBullet.rotation);

    }
}
