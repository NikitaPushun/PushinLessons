using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int _health = 2;    

    private CounterEnemy _counterEnemy = new CounterEnemy();



    #region
    private void Start()
    {
        EnemyKilled = GameObject.FindGameObjectWithTag("UI").GetComponent<CounterEnemy>();
    }


    public void Hurt(int damage)
    {
        _health -= damage;
        

        if (_health <= 0)
        {            
            Die();
            print("Текущее значение " + _counterEnemy);
        }
    }

    private void Die()
    {        
        _counterEnemy.EnemyKilled ++;
        
        Destroy(gameObject);        
    }

    #endregion
}
