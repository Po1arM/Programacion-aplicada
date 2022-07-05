using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollController : MonoBehaviour
{
    MeshRenderer renderer;
    const float scrollingSpeed = 0.2f;
    Vector2 currentPos = Vector2.zero;

    private void Awake(){
        renderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        currentPos.x += scrollingSpeed * Time.deltaTime;
        renderer.material.mainTextureOffset = currentPos;
    }
}
