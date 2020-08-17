using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastVision : MonoBehaviour
{
    [SerializeField] private LayerMask _mask;
    [SerializeField] private Transform _player;

    private void FixedUpdate()
    {
        RaycastHit hit;

        var startPos = transform.position;
        var direction = _player.position - startPos;
        var color = Color.red; // проверить
        var rayCast = Physics.Raycast(startPos, direction, out hit, Mathf.Infinity, _mask);

        if (rayCast)
        {
            if (hit.collider.gameObject.CompareTag("Player"))
            {
                color = Color.green;
            }
        }
        Debug.DrawRay(startPos, direction, color);
       
    }
}
