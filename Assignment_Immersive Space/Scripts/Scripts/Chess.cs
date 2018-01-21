using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chess : MonoBehaviour {

    Chess_4  stacker; 
	GameObject structure, unit;
	int start, end;
	Vector3 offset, nextPosition;



	void Start () {


		WallWithColor();

	}



	void WallWithColor(){

		int start = 0;
		int height = 8;
		offset = new Vector3(0.5f, 0f, 0f);
		nextPosition = Vector3.zero;
		nextPosition.z = .5f;
		stacker = new Chess_4();
		structure = new GameObject();
		structure.name = "Wall With Color";
		structure.transform.position = Vector3.zero;
		Color[] colors = new Color[2];

		colors[0] = Color.white; 
		colors[1] = Color.black;


		int i = 0;
		while( i < 8){
			unit = stacker.Stack(start, height, offset);
			unit.transform.localPosition = nextPosition;
			unit.transform.parent = structure.transform;
			nextPosition.z += 1f;
			i++;
		}


		foreach( Transform child in structure.transform){
			int j = 0;
			foreach(Transform block in child){
				//block.gameObject.GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
				j=j+1;
				if(j%2==0)
					{
						block.gameObject.GetComponent<MeshRenderer>().material.color = colors[0];
					}
				else
					{
						block.gameObject.GetComponent<MeshRenderer>().material.color = colors[1];
					}	
				
				
			}

		}
	}

}
