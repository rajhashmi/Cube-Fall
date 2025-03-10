using UnityEngine;

public class SoundManager : MonoBehaviour{

    public static SoundManager instance;

    [SerializeField]
    private AudioSource soundFX;

    [SerializeField]
    private AudioClip landClip, deathClip, iceBreakClip, gameOverClip;

    void Awake(){
        if(instance == null){
            instance = this;
        }
    }

    public void LandSound(){
        soundFX.clip = landClip;
        soundFX.Play();
    }

    public void IceBreakSound(){
        soundFX.clip = iceBreakClip;
        soundFX.Play();
    }

    public void DeathSound(){
        soundFX.clip = deathClip;
        soundFX.Play();
    }

}
