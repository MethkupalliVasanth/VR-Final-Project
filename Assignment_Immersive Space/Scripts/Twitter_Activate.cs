using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twitter_Activate : MonoBehaviour {




	public GameObject Twitter_Test;



	public void Enable(){

		Twitter_Test.SetActive (true);
	}



	void OnTriggerEnter(Collider otherObject){
		if(otherObject.gameObject.tag == "Player" ){
			Enable ();

		}
	}




}












