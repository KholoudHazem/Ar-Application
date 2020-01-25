using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playNoise : MonoBehaviour {

    // define noise
    public GameObject noiseCube;

	// Use this for initialization
	void Start () {

        // deactivate noise cube at first
        noiseCube.SetActive(true);
        noiseCube.GetComponent<AudioSource>().Play();
	}
	/*
	// Update is called once per frame
	void Update () {

        if ((energySupply.GetComponent<Renderer>().enabled==true)&&
            (energySupply.GetComponent<Collider>().enabled==true))
        {
            noiseCube.SetActive(true);

        }
        else
        {

            noiseCube.SetActive(false);
        }

    }*/
}
