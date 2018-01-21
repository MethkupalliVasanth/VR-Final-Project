using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_9_WallExamples : MonoBehaviour {

	Wall_8_OverLoadingStacks  stacker; 
	GameObject structure, unit;
	int start, end;
	Vector3 offset, nextPosition;


	void Start () {

		//SimpleWall();
		//SimpleTower();
		//WallWithDoor();
		WallWithColor();

	}

	void SimpleWall(){

		offset = new Vector3(0f, 1f, 0f);
		nextPosition = Vector3.zero;
		nextPosition.y = .5f;
		stacker = new Wall_8_OverLoadingStacks();
		structure = new GameObject();
		structure.name = "Wall With Door";
		structure.transform.position = Vector3.zero;

		for(int i = 0; i < 20; i++){
			if(i == 5) start = 3;
			if(i == 7) start = 0;
			unit = stacker.Stack(0, 10, offset);
			unit.transform.localPosition = nextPosition;
			unit.transform.parent = structure.transform;
			nextPosition.x += 1f;
		}
	}

	void WallWithDoor(){

		int start = 0;
		int height = 10;
		offset = new Vector3(0f, 1f, 0f);
		nextPosition = Vector3.zero;
		nextPosition.y = .5f;
		stacker = new Wall_8_OverLoadingStacks();
		structure = new GameObject();
		structure.name = "Wall With Door";
		structure.transform.position = Vector3.zero;

		for(int i = 0; i < 20; i++){
			if(i == 5) start = 3;
			if(i == 7) start = 0;
			unit = stacker.Stack(start, height, offset);
			unit.transform.localPosition = nextPosition;
			unit.transform.parent = structure.transform;
			nextPosition.y += 1f;
		}
	}

	void RandomStacks(){
		offset = new Vector3(0f, 1f, 0f);
		nextPosition = Vector3.zero;
		nextPosition.y = .5f;
		stacker = new Wall_8_OverLoadingStacks();
		structure = new GameObject();
		structure.name = "Random Stacks";
		structure.transform.position = Vector3.zero;
		Vector3 endPoint = new Vector3(Random.Range(-3f, 3f), Random.Range(5f, 20f), Random.Range(-3f, 3f));

		for(int i = 0; i < 20; i++){
			unit = stacker.Stack(Vector3.zero, endPoint);
			unit.transform.localPosition = nextPosition;
			unit.transform.parent = structure.transform;
			nextPosition.x += 1f;
		}
	}
	void WallWithColor(){

		int start = 0;
		int height = 10;
		offset = new Vector3(0f, 1f, 0f);
		nextPosition = Vector3.zero;
		nextPosition.y = .5f;
		stacker = new Wall_8_OverLoadingStacks();
		structure = new GameObject();
		structure.name = "Wall With Color";
		structure.transform.position = Vector3.zero;

		for(int i = 0; i < 20; i++){
			if(i == 5) start = 3;
			if(i == 7) start = 0;
			unit = stacker.Stack(start, height, offset);
			unit.transform.localPosition = nextPosition;
			unit.transform.parent = structure.transform;
			nextPosition.x += 1f;
		}

		foreach( Transform child in structure.transform){
			foreach(Transform block in child){
				block.gameObject.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
			}

		}
	}
	void SimpleTower(){

		offset = new Vector3(0f, 1f, 0f);
		nextPosition = Vector3.zero;
		nextPosition.y = .5f;
		stacker = new Wall_8_OverLoadingStacks();
		structure = new GameObject();
		structure.name = "tower";
		structure.transform.position = Vector3.zero;
		float radius = 3f;
		float deltaAngle = 20f;
		int numUnits = 20;

		for(int i = 0; i < 10; i++){
			unit = stacker.Ring(radius, deltaAngle, numUnits);
			unit.transform.localPosition = nextPosition;
			unit.transform.parent = structure.transform;
			nextPosition.y += 1f;
		}
		radius = 3.5f;
		deltaAngle = 15;
		numUnits = 30;

		for(int i = 0; i < 3; i++){
			unit = stacker.Ring(radius, deltaAngle, numUnits);
			unit.transform.localPosition = nextPosition;
			unit.transform.parent = structure.transform;
			nextPosition.y += 1f;
		}
	}
}
