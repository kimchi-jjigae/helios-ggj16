using UnityEngine;
using System.Collections;

public class SFXPlayer : MonoBehaviour {

    AudioSource moo;
    AudioSource bang;
    AudioSource ignite;

	// Use this for initialization
    void Start () {
        AudioSource[] audios = GetComponents<AudioSource>();
        bang = audios[0];	
        moo = audios[1];
        ignite = audios[2];
	}
	
    public void PlayMoo() {
        moo.Play();
    }
    
    public void PlayBang() {
        bang.Play();
    }

    public void PlayIgnite() {
        ignite.Play();
    }
}
