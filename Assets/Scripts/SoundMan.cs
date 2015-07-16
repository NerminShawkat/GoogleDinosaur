using UnityEngine;
using System.Collections;

public class SoundMan : MonoBehaviour {

    public AudioClip ClipJump;
    public AudioClip ClipDie;
    public AudioClip ClipMain;
    public AudioClip ClipHundred;
    public AudioClip ClipAchivement;
    public AudioSource Jump;
    public AudioSource Die;
    public AudioSource Main;
    public AudioSource Hundred;
    public AudioSource Achivement;

    void Start()
    {
        Jump = gameObject.AddComponent<AudioSource>();
        Jump.clip = ClipJump;
        Die = gameObject.AddComponent<AudioSource>();
        Die.clip = ClipDie;
        Main = gameObject.AddComponent<AudioSource>();
        Main.clip = ClipMain;
        Hundred = gameObject.AddComponent<AudioSource>();
        Hundred.clip = ClipHundred;
        Achivement = gameObject.AddComponent<AudioSource>();
        Achivement.clip = ClipAchivement;
        Jump.playOnAwake = false;
        Die.playOnAwake = false;
        Hundred.playOnAwake = false;
        Achivement.playOnAwake = false;
        Main.loop = true;
        Main.Play();
    }
    
}
