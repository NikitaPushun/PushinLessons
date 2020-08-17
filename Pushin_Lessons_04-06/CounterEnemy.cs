using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CounterEnemy : MonoBehaviour
{
    private Text _score;
    private int _enemyKilled;


    public int Score
    {
        get
        {
            return _score;
        }

        set
        {
            _score = value;
            print("Текущее значение " + _score);
        }

    }

    public int EnemyKilled
    {
        get
        {
            return _enemyKilled;            
        }

        set
        {
            _enemyKilled = value;
            print("Текущее значение " + _enemyKilled);
        }

    }

    private void Start()
    {
        _score = GetComponent<Text>();       
    }

    public void Update()
    {
        _score.text = "Счетчик убитых врагов: " + _enemyKilled;
                      
    }    
}
