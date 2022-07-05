using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    float STARTING_FORCE = 500f;
    bool hasStarted = false;
    Rigidbody rigidbody;
    Vector3 startingForce = new Vector3(1,1);

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!hasStarted && Input.GetButtonDown("Fire1"))
        {
            hasStarted = true;
            startingForce *= STARTING_FORCE;
            rigidbody.AddForce(startingForce);
        }
    }
}
