using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereMovement : MonoBehaviour
{
    const float movementSpeed = 0.1f;
    Vector2 currentPos = Vector2.zero;
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = randomColor();
    }

    void Update()
    {
        currentPos.x += movementSpeed * Time.deltaTime;
        gameObject.transform.Translate(currentPos);
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
