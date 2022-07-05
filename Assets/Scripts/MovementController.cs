using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{

    ScoreManager scoreManager;
    
    Vector3 movementeSpeed = new Vector3(50,50);
    Vector3 deltaPos = new Vector3();

    const float MIN_LIM_Y = -7.16f;
    const float MAX_LIM_Y = 7.16f;

    const float MIN_LIM_X = -13.2f;
    const float MAX_LIM_X = 13.2f;

    private void Awake(){
        scoreManager = GameObject.Find("ScoreManagerText").GetComponent<ScoreManager>();
    }

    void Update()
    {
        deltaPos.x = Input.GetAxis("Horizontal") * movementeSpeed.x;
        deltaPos.y = Input.GetAxis("Vertical") * movementeSpeed.y;

        deltaPos *= Time.deltaTime;

        gameObject.transform.Translate(deltaPos);
        gameObject.transform.position = new Vector3(
            Mathf.Clamp(gameObject.transform.position.x,MIN_LIM_X,MAX_LIM_X),
            Mathf.Clamp(gameObject.transform.position.y,MIN_LIM_Y,MAX_LIM_Y),
            gameObject.transform.position.z
        );

        if(Input.GetButtonDown("Fire1")){
            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Fire1);
            scoreManager.IncrementScore();
        }
        if(Input.GetButtonDown("Fire2"))
            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Fire2);
        if(Input.GetButtonDown("Fire3"))
            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Fire3);
        if(Input.GetButtonDown("Jump"))
            AudioManager.Instance.PlaySoundEffect(AudioManager.SoundEffect.Jump);

    }
}
