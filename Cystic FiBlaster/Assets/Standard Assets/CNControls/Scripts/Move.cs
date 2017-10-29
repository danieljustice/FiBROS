using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;

public class Move : MonoBehaviour {

	public float moveSpeed = 10f;
	private CharacterController _characterController;
	private Transform initialTransform;

	// Use this for initialization
	void OnEnable () {
		_characterController = GetComponent<CharacterController>();
		initialTransform = transform;
	}
	
	// Update is called once per frame
	void Update () {
		var inputVector = new Vector3(-CnInputManager.GetAxis("Horizontal"), CnInputManager.GetAxis("Vertical"));
		Vector3 movementVector = Vector3.zero;
		// If we have some input
		if (inputVector.sqrMagnitude > 0.001f)
		{
			movementVector = initialTransform.TransformDirection(inputVector);
			//movementVector.x = 0f;
			movementVector.Normalize();
			transform.forward = movementVector;
		}

		//movementVector += Physics.gravity;
		//print(movementVector);
		_characterController.Move(movementVector * Time.deltaTime * moveSpeed);
		transform.rotation = Quaternion.LookRotation (-Vector3.forward);
	}
}
