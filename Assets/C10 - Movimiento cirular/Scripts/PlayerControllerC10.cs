using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerC10 : MonoBehaviour
{
    public GameObject Shield;
    const float shieldDistance = 3f;
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Instantiate(Shield, gameObject.transform.position, Quaternion.identity).GetComponent<ShieldBehaviour>().Shoot(gameObject,shieldDistance);
        }
    }
}
