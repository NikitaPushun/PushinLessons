using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MinaSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _mine;
    [SerializeField] private Transform _mineSpawnPlace;
        

    void Update()
    {
     if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(_mine, _mineSpawnPlace.position, _mineSpawnPlace.rotation);
        }
    }
}


