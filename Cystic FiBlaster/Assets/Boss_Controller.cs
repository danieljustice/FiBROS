using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Controller : MonoBehaviour {

	public int boss_life;
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent <Animator>();
		animator.SetBool ("bossdead", false);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (boss_life == 0) {
			print ("You win.");
			animator.SetBool ("bossdead", true);
		} else {
			boss_life -= 10;
			print (boss_life);
		}
		
	}
}
