using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHunter_magnitude: MonoBehaviour {


	public Transform target;
	public Transform t1,t2;
	Rigidbody rb;
	Vector3 heading, newDir, heading1, heading2;
	float power, rSpeed;

	void Start () {
		rb = GetComponent<Rigidbody>();
		power = 15f;
		rSpeed = 5f;
	}
	void FixedUpdate () {
		heading = target.position - transform.position;
		heading1 = t1.position - transform.position;
		heading2 = t2.position - transform.position;
		Debug.Log("heading.magnitude = " + heading.magnitude);




		if (heading.magnitude < 2.5f) {

			rb.AddForce (heading1 * power * Time.deltaTime);
			Debug.DrawRay (transform.position, heading1, Color.red, .2f);
			newDir = Vector3.RotateTowards (transform.forward, heading1, rSpeed * Time.deltaTime, 5f);
			transform.rotation = Quaternion.LookRotation (newDir);

		}

		else {

			rb.AddForce (heading2 * power * Time.deltaTime);
			Debug.DrawRay (transform.position, heading2, Color.red, .2f);
			newDir = Vector3.RotateTowards (transform.forward, heading2, rSpeed * Time.deltaTime, 5f);
			transform.rotation = Quaternion.LookRotation (newDir);


		}
	}




}



