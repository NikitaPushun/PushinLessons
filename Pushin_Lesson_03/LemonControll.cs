using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemonControll : MonoBehaviour
{

    [SerializeField] private float _speed;
    [SerializeField] private float _rotateSpeed;

    private Vector3 _direction;


    #region 

    private void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");

        _direction.Normalize();

        var speed = (_direction.sqrMagnitude > 0) ? _speed : 0f ;
        speed = speed * Time.deltaTime;

        transform.position += transform.forward * speed;

        Vector3 desiredForward = Vector3.RotateTowards(transform.forward, _direction, _rotateSpeed * Time.deltaTime, 0f);
        transform.rotation = Quaternion.LookRotation(desiredForward);
        //transform.Rotate(Vector3.up, _rotateSpeed, Space.World);

    }

    #endregion 


    #region

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Bonus"))
    //    {
    //        TakeHealthBonus._bonusCount +=1;
    //        Destroy(gameObject);
    //    }
    //}

    #endregion

}
