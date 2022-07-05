using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c3PlayerController : MonoBehaviour
{
    float speedY = 2f;
    Vector3 deltaPos = new Vector3();

    const float MIN_LIM_Y = -4.4f;
    const float MAX_LIM_Y = 4.4f;
    
    void Update()
    {
        deltaPos.y = Input.touchSupported && Input.touchCount > 0 ? Input.GetTouch(0).position.y : 0;
        deltaPos.y *= speedY;
        deltaPos *= Time.deltaTime;
        gameObject.transform.Translate(deltaPos);

        gameObject.transform.position = new Vector3(gameObject.transform.position.x,
            Mathf.Clamp(gameObject.transform.position.x, MIN_LIM_Y, MAX_LIM_Y),
            gameObject.transform.position.z);
    }
}
