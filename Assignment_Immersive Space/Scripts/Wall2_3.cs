using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall2_3 : MonoBehaviour {

	Windows  stacker; 
	GameObject structure, unit;
	int start, end;
	Vector3 offset, nextPosition;


	void Start () {

		WallWithColor();

	}



	void WallWithColor(){

		int start = 0;
		int height = 10;
		offset = new Vector3(0f, 1f, 0f);
		nextPosition =  new Vector3(-10f, 0f, -45f);
		nextPosition.y = .5f;
		stacker = new Windows();
		structure = new GameObject();
		structure.name = "Wall With Color";
		structure.transform.position = Vector3.zero;

		for(int i = 0; i < 20; i++){



			if(i == 9) start = 3;
			if(i == 12) start = 0;
			unit = stacker.Stack(start, height, offset);
			unit.transform.localPosition = nextPosition;
			unit.transform.parent = structure.transform;
			nextPosition.z += 1f;
		}

		foreach( Transform child in structure.transform){
			foreach(Transform block in child){
				block.gameObject.GetComponent<MeshRenderer>().material.color = new Color(0.2F, 0.3F, 0.4F, 0.5F);
			}

		}
	}

}

