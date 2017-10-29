using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeHits : MonoBehaviour {

    public int HP = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Destroy(collision.gameObject);
            HP--;
            CheckAlive();
        }
    }

    private void CheckAlive()
    {
        if(HP <= 0)
        {
            Destroy(gameObject.transform.parent.gameObject); 
        }
    }
}
