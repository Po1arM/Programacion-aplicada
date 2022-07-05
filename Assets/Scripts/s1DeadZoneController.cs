using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class s1DeadZoneController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
