using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/Shot")]
public class ShotProjectile : Shot {
	public float projectileForce = 150;
	public Rigidbody projectile;

	private ShotTrigger shotTrigger;

	public override void InitializeShot(GameObject obj){
		shotTrigger = obj.GetComponent<ShotTrigger> ();
		shotTrigger.projectileForce = projectileForce;
		shotTrigger.projectile = projectile;
		if (shotTrigger == null) {
			Debug.Log ("STARTS OFF NULL");
		}
	}

	public override void TriggerShot (){
		if (shotTrigger == null) {
			Debug.Log ("IS NULL");
		}
		shotTrigger.Shoot ();
	}
}
