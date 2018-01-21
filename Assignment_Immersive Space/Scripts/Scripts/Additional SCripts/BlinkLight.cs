using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkLight : MonoBehaviour {
	public float totalSeconds;     // The total of seconds the flash wil last
	public float maxIntensity;     // The maximum intensity the flash will reach
	public Light myLight;        // Your light
	public Color lightColor = new Color (1,0,0,0);

	bool isDimming = false;
	Material mat;
	float deltaAlpha;

	void Start() {
		mat = gameObject.GetComponent<Renderer> ().material;
		myLight.intensity = 0;
		myLight.color = lightColor;
		mat.color = lightColor;
		deltaAlpha = 1 / (maxIntensity/0.1f);
		print (deltaAlpha);
	}

	void FixedUpdate ()
	{
		float waitTime = totalSeconds / 2;

		Color current = mat.color;

		if (!isDimming) {
			myLight.intensity += 0.1f;        // Increase intensity
			mat.color = mat.color + new Color(0,0,0,deltaAlpha);
			if (myLight.intensity > maxIntensity)
				isDimming = !isDimming;
		} else {
			myLight.intensity -= 0.1f;        //Decrease intensity
			mat.color = mat.color - new Color(0,0,0,deltaAlpha);
			if (myLight.intensity <= 0)
				isDimming = !isDimming;
		}
	}
}
