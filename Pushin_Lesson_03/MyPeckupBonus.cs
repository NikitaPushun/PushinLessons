using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPeckupBonus : MonoBehaviour
{
    [SerializeField] private int _health = 1;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var player = collision.gameObject.GetComponent<TakeHealthBonus>();
            player.Health(_health);

            Destroy(gameObject);
        }
    }
}
