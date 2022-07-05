using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerC9 : MonoBehaviour
{
    Vector3 startingSpeed;
    Vector3 userInput = new Vector3();
    const float SCALAR_SPEED = 20f;
    float currentAngle, deltaY, deltaX;
    public GameObject amunition;

    void Start()
    {
        startingSpeed = new Vector3(SCALAR_SPEED, SCALAR_SPEED);
    }

    // Update is called once per frame
    void Update()
    {
        userInput = Camera.main.ScreenToWorldPoint(Input.touchSupported && Input.touchCount > 0 ? (Vector3)Input.GetTouch(0).position : Input.mousePosition);
        deltaY = userInput.y - gameObject.transform.position.y;
        deltaX = userInput.x - gameObject.transform.position.x;

        currentAngle = Mathf.Atan(deltaY/deltaX);

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(amunition,gameObject.transform.position, Quaternion.identity).GetComponent<AmunitionBehaviour>().Shoot(startingSpeed,currentAngle);
        }
    }
}
