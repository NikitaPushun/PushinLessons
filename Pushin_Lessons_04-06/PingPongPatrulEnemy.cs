using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PingPongPatrulEnemy : MonoBehaviour
{
    #region Fields

    [SerializeField] Transform[] _patrollingPoint;
    [SerializeField] float _speed;
    [SerializeField] private bool _flag = false;

    #endregion

    #region UnityMethods

    private void Start()
    {
        transform.position = _patrollingPoint[0].position;        
    }


    private void Update()
    {   
        if (_flag == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, _patrollingPoint[1].position, _speed * Time.deltaTime);

            if (transform.position == _patrollingPoint[1].position)
            {
                _flag = true;               
            }
        }

        else
        {
            transform.position = Vector3.MoveTowards(transform.position, _patrollingPoint[0].position, _speed * Time.deltaTime);

            if (transform.position == _patrollingPoint[0].position)
            {
                _flag = false;
            }
        }
    }

    #endregion
}






