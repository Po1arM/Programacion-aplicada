using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBehaviour : MonoBehaviour
{
    GameObject centerObject;
    Vector3 currentposition = new Vector3(),angle, currentSpeed = new Vector3();
    float currentDistance, scalarAceleration = 8f, shootingTime;
    void Update()
    {
        angle = currentSpeed * (Time.time - shootingTime) / currentDistance;
        currentposition.x = centerObject.transform.position.x + currentDistance * Mathf.Cos(angle.x);
        currentposition.y = centerObject.transform.position.y + currentDistance * Mathf.Sin(angle.y);
        gameObject.transform.position = currentposition;

        currentSpeed.x += scalarAceleration * Time.deltaTime;
        currentSpeed.y += scalarAceleration * Time.deltaTime;
            
    }

    public void Shoot(GameObject center,float distance)
    {
        centerObject = center;
        currentDistance = distance;
        shootingTime = Time.time;
    }
}
