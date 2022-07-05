using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementController : MonoBehaviour
{
    const float MAX_Y = 8f, SPEED_Y = 15f;
    Vector3 currentPos = new Vector3();
    
    // Update is called once per frame
    void Update()
    {
        currentPos.y = -4 + Mathf.PingPong(Time.time * SPEED_Y, MAX_Y);
        gameObject.transform.position = currentPos;
    }
}
