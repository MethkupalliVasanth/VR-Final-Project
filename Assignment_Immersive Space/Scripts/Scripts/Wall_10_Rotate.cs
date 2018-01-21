using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_10_Rotate : MonoBehaviour {

	public Vector3 direction; //Because direction is public, you can set its values in the Inspector

	void Update() 
	{
		transform.Rotate(direction * Time.deltaTime);
	}
}
