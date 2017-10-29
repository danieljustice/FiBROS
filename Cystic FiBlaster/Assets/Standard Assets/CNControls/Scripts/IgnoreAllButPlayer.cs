using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreAllButPlayer : MonoBehaviour {



 	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag != "Player")
		{
			//Physics.IgnoreCollision(theobjectToIgnore.collider, collider);
            //Collider col = collision.
			Physics.IgnoreCollision(collision.gameObject.GetComponent<Collider>(), GetComponent<Collider>());
          
		}
	}

}
