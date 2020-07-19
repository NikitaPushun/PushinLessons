using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstntinateObject : MonoBehaviour
{
    [SerializeField] private GameObject _candl;
    [SerializeField] private Transform _spavnPointl;
    [SerializeField] private GameObject _anotherObject;

        

    void Start()
    {
        //Instantiate(_candl, _spavnPointl.position, _spavnPointl.rotation);
        //Destroy(gameObject, 3);

        //gameObject.SetActive(false);

        //_anotherObject.SetActive(false);

        //transform.parent.gameObject.SetActive(false);

        //transform.GetChild(0).gameObject.SetActive(false);

        //GameObject.Find("Candl").SetActive(false);

        //GameObject.FindWithTag("Envire").transform.position = new Vector3(0, 10, 10);

        //GameObject.FindWithTag("Envire").GetComponent<BoxCollider>().enabled = false;

        //Destroy(gameObject.GetComponent<MeshRenderer>(), 3);

        //GameObject.Find("Candl").SetActive(false);

        print(gameObject.tag);

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Destroy(gameObject, 3);

        
    }

    
    void Update()
    {
        //if (Input.GetMouseButton(0))
        //    print("LMB нажата");
        //if (Input.GetMouseButtonUp(1))
        //    print("MMB отпущена");
        //if (Input.GetMouseButtonDown(2))
        //    print("RMB cliced");

        //float h = Input.GetAxis("Horizontal");
        //print("Value h = " + h);

        //if (Input.GetButton("Horizontal"))
        //    print("Клавиша нажата");

    }
}
