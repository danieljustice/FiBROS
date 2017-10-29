using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewSection : MonoBehaviour {
    public GameObject section;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        print(other.tag);
        if (other.tag == "Player" && section != null)
        {
            section.SetActive(true);
            Destroy(transform.parent.gameObject);
        }
    }
}
