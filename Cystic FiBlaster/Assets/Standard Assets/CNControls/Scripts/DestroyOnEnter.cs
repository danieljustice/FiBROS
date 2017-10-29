using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnEnter : MonoBehaviour {
    //public Tag tagToDestroy;
    public string tag;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        //print(other.tag);
        if (other.tag == tag)
        {
           // print("DESTROY");
            Destroy(other.gameObject);
        }
    }
    //void OnTriggerEnter(Collider other)
    //{
    //    print("Something entered");
    //    if (other.tag == tag)
    //    {
    //        Destroy(other.gameObject);
    //    }
    //}
}
