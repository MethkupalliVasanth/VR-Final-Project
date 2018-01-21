using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMaterial : MonoBehaviour {


	// Material Variables
	float currentTemp, maxTemp, lerpMat ;

	public Material coolMat, hotMat;
	Material currentMat;

	bool heating;// If true, heat increasing, else decreasing

	void Start () {
		currentMat = GetComponent<MeshRenderer>().material;
		maxTemp = 3f;
	}


	void Update () {

		lerpMat = currentTemp / maxTemp ;
		currentMat.Lerp(coolMat, hotMat, lerpMat);

		if(heating){
			currentTemp += Time.deltaTime/2f;
		} else {
			currentTemp -= Time.deltaTime/2f;;
		}

		// Press the M key to change the value of heating
		if (Input.GetKeyDown(KeyCode.M)){
			heating = !heating;
		}
	}
		
}