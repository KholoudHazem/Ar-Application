using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energySupplyAudio : MonoBehaviour {

    public AudioSource noise;

	// Use this for initialization
	void play () {
        noise.Play();
	}
	
	// Update is called once per frame
	void stop () {
        noise.Stop();
	}
}
