using UnityEngine;
using System.Collections;

public class PlayMusic : MonoBehaviour {

    AudioSource music;

	void Start() {
	    music = GetComponent<AudioSource>();
	}
	
	void Play() {
	    music.Play();
	}
}
