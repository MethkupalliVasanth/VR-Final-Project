using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Changer : MonoBehaviour {





	Color startColor, endColor, currentColor;
	float lerp_color, alphaStart, alphaEnd;
	Material mat;
	float lerp;



	void Start () {
		
		mat = GetComponent<MeshRenderer>().material;
		SetColors();

	

	}


	void Update () {

		//	transform.Rotate(deltaRotation);
		//	transform.Translate(deltaPosition);
		//}

		lerp = Mathf.PingPong(Time.time, 3f);

		lerp_color = (Mathf.Sin(Time.time) / 2f) +.5f;
		currentColor = Color.Lerp(startColor, endColor, lerp);
		currentColor.a = Mathf.Lerp(alphaStart, alphaEnd, lerp);

		mat.color = currentColor;
		if(lerp_color< .0001) SetColors();


	}



	void SetColors(){
		startColor = currentColor;
		endColor =    Random.ColorHSV();
		alphaStart = currentColor.a;
		alphaEnd = Random.value;
	}







}


