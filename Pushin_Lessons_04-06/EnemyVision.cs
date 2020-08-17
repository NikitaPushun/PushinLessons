using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//public class EnemyVision : MonoBehaviour
//{
//    [SerializeField] private string _targetTag = "Player";
//    [SerializeField] private float _rays = 8.0f;
//    [SerializeField] private float _distance = 30.0f;
//    [SerializeField] private float _angle = 40.0f;
//    [SerializeField] private Vector3 _offcet;
//    [SerializeField] private Transform _target;
//    [SerializeField] private NavMeshAgent Nana;

//    private void Start()
//    {
//        _target = GameObject.FindGameObjectWithTag(_targetTag).transform;
//        Nana = GetComponent<NavMeshAgent>();
//    }

//    private bool GetRaycast(Vector3 direction)
//    {
//        bool result = false;
//        RaycastHit hit = new RaycastHit();
//        Vector3 pos = transform.position + _offcet;

//        if (Physics.Raycast(pos, direction, out hit, _distance))
//        {
//            if (hit.transform == _target)
//            {
//                result = true;
//                Debug.DrawLine(pos, hit.point, Color.green);
//            }
//            else
//            {
//                Debug.DrawLine(pos, hit.point, Color.blue);
//            }
//        }
//        else
//        {
//            Debug.DrawLine(pos, hit.point, Color.red);
//        }
//    }

//    private bool RayToScan()
//    {
//        bool resalt = false;
//        bool a = false;
//        bool b = false;
//        float j = 0;

//        for (int i = 0; i < _rays; i ++)
//        {
//            var x = Mathf.Sin(j);
//            var y = Mathf.Cos(j);

//            j += _angle * Mathf.Deg2Rad / _rays;

//            Vector3 dir = transform.TransformDirection(new Vector3(x, 0, y));

//            if (x != 0)
//            {
//                dir = transform.TransformDirection(new Vector3(-x, 0, y));
//                if (GetRaycast(dir)) b = true;
//            }
                
//        }

//        if (a || b) resalt = true;
//    }

//    private void Update()
//    {
//        if (Vector3.Distance(transform.position, _target.position) < _distance)
//        {
//            if (RayToScan ())
//            {
//                Nana.enabled = true;
//            }
//            else
//            {

//            }
//        }
//    }

//}
