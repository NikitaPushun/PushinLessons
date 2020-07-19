using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform _posSpawnPlace;
    [SerializeField] private float nextSpawnTime = 0.0f;


    //void Update()
    //{
    //    if (GameObject.Collider collision)

    //        Instantiate(_enemy, _posSpawnPlace.position, _posSpawnPlace.rotation);
    //}
}
