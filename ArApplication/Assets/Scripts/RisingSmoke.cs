using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingSmoke : MonoBehaviour {

    // Define smoke 1 and smoke 2 as game objects.
    public GameObject smoke1, smoke2;

	
	void Start () {
        // make smoke visible
        smoke1.SetActive(true);
        smoke2.SetActive(true);
	}
	
}
