using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lung_Controller : MonoBehaviour {

	public bool breathing;
	public int stopcounter;

	private Animator animator;
	private int counter;

	// Use this for initialization
	void Start () {
		counter = 0;
		if (stopcounter == null)
			stopcounter = 30;

		animator = GetComponent <Animator>();
		animator.SetBool ("breathing", true);
	}
	
	// Update is called once per frame
	void Update () {
		if (counter == stopcounter) {
			print ("times up");
			animator.SetBool ("breathing", false);
		} else {
			counter += 1;
		}
	}
}
