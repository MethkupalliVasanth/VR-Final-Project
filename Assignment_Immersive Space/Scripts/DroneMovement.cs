using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMovement : MonoBehaviour {


	Rigidbody ourDrone;
	// Use this for initialization
	void Awake(){
		ourDrone = GetComponent<Rigidbody> ();

	}

	void FixedUpdate(){
		MovementUpDown ();
		MovementForward ();

		ourDrone.AddRelativeForce (Vector3.up * upForce);
		ourDrone.rotation = Quaternion.Euler (
			new Vector3(tiltAmountForward, ourDrone.rotation.y, ourDrone.rotation.z)
		);
	}

	public float upForce;

	void MovementUpDown(){
		if (Input.GetKey (KeyCode.I)) {
			upForce = 450;
		}
		if (Input.GetKey (KeyCode.K)) {
			upForce = -200;
		} 
		else if (!Input.GetKey (KeyCode.I) && !Input.GetKey (KeyCode.K)) {
			upForce = 98;	
		}
	}

	private float movementForwardSpeed = 5.0f;
	private float tiltAmountForward = 0;
	private float tiltVelocityForward;

	void MovementForward(){
		if(Input.GetAxis("Vertical")!=0){
			ourDrone.AddRelativeForce (Vector3.forward * Input.GetAxis ("Vertical") * movementForwardSpeed);
			tiltAmountForward = Mathf.SmoothDamp (tiltAmountForward, 20 * Input.GetAxis ("Vertical"), ref tiltVelocityForward, 0.1f);
		}
		
		
	}


}
