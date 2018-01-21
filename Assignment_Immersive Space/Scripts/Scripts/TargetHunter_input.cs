using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHunter_input: MonoBehaviour {


	public Transform target;
	public Transform t1,t2,t3,t4;
	Rigidbody rb;
	Vector3 heading, newDir, heading1, heading2, heading3, heading4;
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
		heading3 = t3.position - transform.position;
		heading4 = t4.position - transform.position;
		Debug.Log ("heading.magnitude for = " + heading.magnitude);

		if (Input.GetKey("up"))
			print("up arrow key is held down");

		if (Input.GetKey("down"))
			print("down arrow key is held down");

		if (Input.GetKey ("up")) {

			rb.AddForce (heading1 * power * Time.deltaTime);
			Debug.DrawRay (transform.position, heading1, Color.red, .2f);
			newDir = Vector3.RotateTowards (transform.forward, heading1, rSpeed * Time.deltaTime, 5f);
			transform.rotation = Quaternion.LookRotation (newDir);

		}

		if (Input.GetKey ("down")) {

			rb.AddForce (heading4 * power * Time.deltaTime);
			Debug.DrawRay (transform.position, heading4, Color.red, .2f);
			newDir = Vector3.RotateTowards (transform.forward, heading4, rSpeed * Time.deltaTime, 5f);
			transform.rotation = Quaternion.LookRotation (newDir);
		}

		if (Input.GetKey ("left")) {

			rb.AddForce (heading2 * power * Time.deltaTime);
			Debug.DrawRay (transform.position, heading2, Color.red, .2f);
			newDir = Vector3.RotateTowards (transform.forward, heading2, rSpeed * Time.deltaTime, 5f);
			transform.rotation = Quaternion.LookRotation (newDir);

		}

		if (Input.GetKey ("right")) {

			rb.AddForce (heading3 * power * Time.deltaTime);
			Debug.DrawRay (transform.position, heading3, Color.red, .2f);
			newDir = Vector3.RotateTowards (transform.forward, heading3, rSpeed * Time.deltaTime, 5f);
			transform.rotation = Quaternion.LookRotation (newDir);


		}


	}




}



