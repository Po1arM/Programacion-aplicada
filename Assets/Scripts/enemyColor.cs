using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyColor : MonoBehaviour
{
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = randomColor();
    }

    Color randomColor()
    {
        switch (Random.Range(0, 3))
        {
            case 0:
                return Color.green;
            case 1:
                return Color.red;
            default:
                return Color.yellow;
        }
    }
}
