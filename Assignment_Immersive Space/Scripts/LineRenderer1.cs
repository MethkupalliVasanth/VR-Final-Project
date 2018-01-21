using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRenderer1 : MonoBehaviour {
	/*
	 * This script accesses the LineRenderer component
	 * of this object, sets position 0 to transform.position
	 * then dynamicly sets position 1 to target.position.
	 * 
	 * You can add more positions with lr.SetVertexCount;
	 * 
	 * */


	public Transform target;
	LineRenderer lr;
	Vector3 heading;

	void Start () {
		lr = GetComponent<LineRenderer>();
		lr.SetPosition(0, transform.position);

	}
	void Update () {
		lr.SetPosition(1, target.position);
	}
}
