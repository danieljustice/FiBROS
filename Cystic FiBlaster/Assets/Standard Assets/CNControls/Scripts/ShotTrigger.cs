using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotTrigger : MonoBehaviour {
	[HideInInspector]
	public Rigidbody projectile;
	public Transform firePoint;
	[HideInInspector]
	public float projectileForce;



	public void Shoot(){
		Rigidbody clonedProjectile = Instantiate (projectile, firePoint.position, transform.rotation) as Rigidbody;
		clonedProjectile.AddForce (-firePoint.transform.right * projectileForce);
	}
}
