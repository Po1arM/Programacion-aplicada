using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementTiroLibre : MonoBehaviour
{
    Vector2 deltaPos = new Vector2();
    
    
    const float MIN_LIM_X = -8.18f, MAX_LIM_X = 8.18f, MOVE_SPEED = 20;

    public GameObject proyectile;

    void Start()
    {
        
    }

    void Update()
    {
        deltaPos.x = Input.GetAxis("Horizontal") * MOVE_SPEED;

        deltaPos *= Time.deltaTime;

        gameObject.transform.Translate(deltaPos);
        gameObject.transform.position = new Vector2(
            Mathf.Clamp(gameObject.transform.position.x, MIN_LIM_X, MAX_LIM_X),
            -4.47f);

        if (Input.GetButtonDown("Fire1"))
        {
            Vector2 proyectileStartingPos = new Vector2(gameObject.transform.position.x, -3.501661f);
            Instantiate(proyectile, proyectileStartingPos, Quaternion.identity);
        }
    }

}
