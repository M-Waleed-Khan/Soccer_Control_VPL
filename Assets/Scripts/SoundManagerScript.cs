using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {
    public static AudioClip bounceSound;
    static AudioSource audioSrc;
	// Use this for initialization
	void Start () {
        bounceSound = Resources.Load < AudioClip>("Bounce Sound Effect");
        audioSrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	public static void PlaySound (string clip) {
        audioSrc.PlayOneShot(bounceSound);
        
		
	}

}
