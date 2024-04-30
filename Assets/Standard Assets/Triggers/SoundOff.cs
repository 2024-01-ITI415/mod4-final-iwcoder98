using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOff : MonoBehaviour
{
    public AudioSource audioSrc;

	void OnTriggerEnter(Collider other) {
		// when the trigger is hit by something
		// check to see if it's a Projectile 
		if (other.gameObject.tag == "Player") {
			audioSrc.Stop();
		}
	}
}
