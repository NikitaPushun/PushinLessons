using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveEnemyTransformPosition : MonoBehaviour
{
    //Доработать скрипт патрулирования на основе transform

    [SerializeField] private int _speed;
       
       
    void Update()
    {
        transform.position += Vector3.forward * _speed * Time.deltaTime;
        
        if (transform.position.z < 10f)
        {
            transform.position += - Vector3.forward * _speed * Time.deltaTime;
        }
        //else if (transform.position.z < 20f)
        //{
        //    transform.position -= Vector3.forward * _speed * Time.deltaTime;
        //}
    }
}
