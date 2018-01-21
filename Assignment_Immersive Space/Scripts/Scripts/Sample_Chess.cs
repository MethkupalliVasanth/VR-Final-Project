using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample_Chess : MonoBehaviour {

	// Use this for initialization
	public Transform prefab;

	void Start () {
		Example ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}






	void Example(){
		int j = 0;
		while (j < 8) {


			int i = 0;
			while (i < 8) {

				var mynewObj= Instantiate (prefab, new Vector3 (i * 0.6f, 0, j*0.6f), Quaternion.identity);
				if ((i+j) % 2 == 0) {
					mynewObj.GetComponent<Renderer> ().material.color = Color.white;
				}
				else 
				{
					mynewObj.GetComponent<Renderer> ().material.color = Color.black;
				}
				i++;
			}
			j++;
		}
			
		}
		
}
