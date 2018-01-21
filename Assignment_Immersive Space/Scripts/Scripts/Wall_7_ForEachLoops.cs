using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_7_ForEachLoops : MonoBehaviour {

	Wall_8_OverLoadingStacks stacker; 
	GameObject unit;
	Vector3 offset, rotation, newScale;
	float hScaler;

	void Start () {

		ColorLoop();
		ColorAndRotate();
		ColorRotateAndScale();
	}

	void ColorLoop(){
		offset = new Vector3(0f, 1f, 0f);
		stacker = new Wall_8_OverLoadingStacks();

		unit = stacker.Stack(0, 10, offset);
		unit.name = "For Each Color";
		unit.transform.position = new Vector3(5f, .5f, 0f);

		foreach(Transform block in unit.transform){
			block.gameObject.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
		}
	}
	void ColorAndRotate(){
		rotation =  Vector3.zero;
		offset = new Vector3(0f, 1f, 0f);
		stacker = new Wall_8_OverLoadingStacks();

		unit = stacker.Stack(0, 15, offset);
		unit.name = "For Each Rotation";
		unit.transform.position = new Vector3(0f, .5f, 0f);

		foreach(Transform block in unit.transform){
			block.gameObject.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
			rotation.y += 10f;
			block.Rotate(rotation);
		}
	}
	void ColorRotateAndScale(){
		rotation =  Vector3.zero;
		hScaler = 1f;
		newScale = Vector3.one;
		offset = new Vector3(0f, 1f, 0f);
		stacker = new Wall_8_OverLoadingStacks();

		unit = stacker.Stack(0, 15, offset);
		unit.name = "For Each Scale";
		unit.transform.position = new Vector3(-5f, .5f, 0f);

		foreach(Transform block in unit.transform){
			block.gameObject.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
			rotation.y += 10f;
			block.Rotate(rotation);
			newScale.x *= hScaler;
			newScale.z *= hScaler;
			block.localScale = newScale;
			hScaler *= 1.03f;
		}
	}
}
