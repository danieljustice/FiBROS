using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatEnzyme : MonoBehaviour {

    public IsEatable isEat;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        //print(other.tag);
        if (other.tag == "Player")
        {
            isEat.IsNowEatable();
        }
    }
}
