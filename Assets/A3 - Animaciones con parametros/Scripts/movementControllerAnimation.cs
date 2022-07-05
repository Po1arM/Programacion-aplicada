using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementControllerAnimation : MonoBehaviour
{
    Animator currentAnimator;
    float maxRunningSpeed= 15f, MaxWalkingSpeed = 8f,currentSpeed;
    Vector3 deltaPos = new Vector3();
    SpriteRenderer renderer;
    void Start()
    {
        currentAnimator = GetComponent<Animator>();
        renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            currentAnimator.SetBool("isAttacking", true);
        }else if (Input.GetButtonUp("Fire1"))
        {
            currentAnimator.SetBool("isAttacking", false);
        }

        
        currentSpeed = Input.GetAxis("Horizontal") * (Input.GetButton("Fire3")   ? maxRunningSpeed : MaxWalkingSpeed);
        deltaPos.x =  currentSpeed * Time.deltaTime;
        currentAnimator.SetFloat("speed", Mathf.Abs(currentSpeed));
        renderer.flipX = currentSpeed < 0;

        gameObject.transform.Translate(deltaPos);
    }
}
