using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Trigger : MonoBehaviour {





	AudioSource soundPlayer;
	public bool moving;

	void Start () {

		soundPlayer = GetComponent<AudioSource>();

	}


	void Update () {
		

		if (!moving) {
			soundPlayer.Play(); 
		}



	}

	void OnTriggerEnter(Collider otherObject){
		if(otherObject.gameObject.tag == "Player" ){
			moving = true;

		}
	}

	void OnTriggerExit(Collider otherObject){
		if(otherObject.gameObject.tag == "Player" ){
			moving = false;
		}
	}








}


