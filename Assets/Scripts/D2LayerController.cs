using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D2LayerController : MonoBehaviour
{
    float scrollingSpeed = 0.2f, currentTempSpeed;
    MeshRenderer renderer;
    Vector2 currentPos = new Vector2();
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        currentTempSpeed = (float)(scrollingSpeed * (gameObject.transform.position.z/12.4));
        currentPos.x = currentPos.x + currentTempSpeed * Time.deltaTime;
        renderer.material.mainTextureOffset = currentPos; 
    }
}
