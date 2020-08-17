using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyConstrutor : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private int _health;

    public EnemyConstrutor (string newName, int newHealth)
    {
        _name = newName;
        _health = newHealth;
    }

    public int CompareTo(EnemyConstrutor other)
    {
        if (other == null)
        {
            return 1;
        }

        return _health - other._health;
    }
}
