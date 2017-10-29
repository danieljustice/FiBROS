using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnDeath : MonoBehaviour {
    AudioSource audioS;
	// Use this for initialization
	void Start () {
        audioS = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnDisable()
    {
        audioS.enabled = true;
    }
}
