using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeHealthBonus : MonoBehaviour
{
    [SerializeField] private int _health = 2;

    public void Health (int health)
    {
        _health += health;
    }
}
