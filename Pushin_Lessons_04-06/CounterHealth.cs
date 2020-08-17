using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CounterHealth : MonoBehaviour
{
    private Text _text;
    public static int _healthScore = 100;


    //public int HealthScore
    //{
    //    get
    //    {
    //        return _healthScore;
    //    }

    //    set
    //    {
    //        _healthScore = value;
    //    }
    //}

    private void Start()
    {
        _text = GetComponent<Text>();
    }

    public void Update()
    {
        _text.text = "Здоровье: " + _healthScore;
    }
}
