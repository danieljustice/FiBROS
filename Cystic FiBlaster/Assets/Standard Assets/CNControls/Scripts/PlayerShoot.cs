using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {


	[SerializeField]
	private Shot shot;
	[SerializeField]
	private GameObject weaponHolder;

	private float coolDownDuration;
	private float nextReadyTime;
	private float coolDownTimeLeft;


	// Use this for initialization
	void Start () {
		Initialize (shot, weaponHolder);
	}

	public void Initialize(Shot selectedShot, GameObject weaponHolder){
		shot = selectedShot;
		coolDownDuration = shot.abilityBaseCoolDown;
		shot.InitializeShot (weaponHolder);
		ShotReady ();
	}

	// Update is called once per frame
	void Update () {
		bool coolDownComplete = (Time.time > nextReadyTime);;
		if (coolDownComplete) {
			ShotReady ();
			Shoot ();
		} else {
			CoolDown();
		}
	}


	private void CoolDown(){
		coolDownTimeLeft -= Time.deltaTime;
		float roundedCD = Mathf.Round (coolDownTimeLeft);
		//coolDownTextDisplay.text = roundedCD.ToString();
	}


	void ShotReady(){
		//show that it is ready, nothing right now
	}

	private void Shoot(){
		nextReadyTime = coolDownDuration + Time.time;
		coolDownTimeLeft = coolDownDuration;
		shot.TriggerShot ();
	}
}
