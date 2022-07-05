using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c4MovementController : MonoBehaviour
{
    public FloatingJoystick joystick;
    Vector3 deltaPos = new Vector3();
    Vector3 movementSpeed = new Vector3(10, 10);
    const float MIN_X = -8.2f, MAX_X = 8.2f, MIN_Y = -4.3f, MAX_Y = 4.3f;
    void Update(){
        deltaPos.x = joystick.Horizontal * movementSpeed.x;
        deltaPos.y = joystick.Vertical * movementSpeed.y;
        deltaPos *= Time.deltaTime;

        gameObject.transform.Translate(deltaPos);

        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x, MIN_X, MAX_X),
            Mathf.Clamp(gameObject.transform.position.y, MIN_Y, MAX_Y),
            gameObject.transform.position.z);
    }
}
