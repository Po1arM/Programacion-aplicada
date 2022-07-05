using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class railMovement : MonoBehaviour
{
    float MAX_POS_X = 10f, MOVE_SPEED = 5f;
    Vector2 position = new Vector2(0, 3.14f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position.x = -4 + Mathf.PingPong(Time.time * MOVE_SPEED, MAX_POS_X);
        gameObject.transform.position = position;
    }
}
