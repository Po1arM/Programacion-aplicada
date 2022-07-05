using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public enum SoundEffect{
        Fire1,
        Fire2,
        Fire3,
        Jump,
    }

    public enum BackGroundMusic{
        backgroundMusic1
    }

    public AudioSource fire1Effect;
    public AudioSource fire2Effect;
    public AudioSource fire3Effect;
    public AudioSource Jump;
    public AudioSource backgroundMusic;

    public static AudioManager Instance;

    private void Awake(){
        Instance = this;
    }

    public void PlaySoundEffect(SoundEffect type){
        switch (type)
        {
            case SoundEffect.Fire1:
                fire1Effect.Play();
                break;
                
            case SoundEffect.Fire2:
                fire2Effect.Play();
                break;

            case SoundEffect.Fire3:
                fire3Effect.Play();
                break;

            case SoundEffect.Jump:
                Jump.Play();
                break;

        }
    }
    public void PlaybackgroundMusic(BackGroundMusic type){
        switch (type)
        {
            case BackGroundMusic.backgroundMusic1:
                fire1Effect.Play();
                break;
                
        }
    }
}
