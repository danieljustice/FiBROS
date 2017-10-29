using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MucusBomb : MonoBehaviour {
    public string tag;
    public GameObject[] mucusToDestroy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == tag)
        {
            // print("DESTROY");
            for(int i=0; i < mucusToDestroy.Length; i++)
            {
                Destroy(mucusToDestroy[i]);
            }

            Destroy(gameObject.transform.parent.gameObject);
        }
    }
}
