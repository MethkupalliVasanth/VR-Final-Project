using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chess_4 : MonoBehaviour {
	/*
	 *	This is a slightly simplified version of the public Stacks Class.
	 *	As you'll see in a bit, it is easy to vary the color of the children 
	 *	of a gameObject, so we won't bother to do it here.
	 * */

	GameObject newObj, stack;
	Vector3 nextPos, step;



	public GameObject Stack (int bottom, int height, Vector3 step) {

		nextPos = Vector3.zero;// This will be at 0, 0, 0
		stack = new GameObject(); // Create a gameObject to hold the stack
		stack.name = "Simple Stack"; // Name it Stack
		stack.transform.position = nextPos; // Place stack at nextPos

		nextPos.y = (float) bottom;// we want the stack to start wherever the bottom is

		for (int i = bottom; i < height; i++){
			newObj = GameObject.CreatePrimitive(PrimitiveType.Cube); // Creates a primative cube
			newObj.transform.position = nextPos; // moves it to nextPos
			newObj.name = "Block " + i;
			newObj.transform.parent = stack.transform; // Makes it a child of the new game object named stack
			nextPos += step; 
		}
		return stack;
	}

	/*
	 *	It is possible to have two or more functions with the same name as long as 
	 *	the arguments they expect are different. The first version of stack asks for
	 *	integers for the bottom and top of the stack and a vector for the offset.
	 *
	 *	The second function asks for a start and end position, then builds the stack
	 *	from one to the other. Both have the same name, but require different arguments.
	 *
	 *	The ability to do this is called "overloading" because it allows a given function
	 *	to respond in a number of different ways. Most of the Unity functions do this.
	 *
	 * */

	public GameObject Stack (Vector3 startPos, Vector3 endPos) {

		nextPos = startPos;
		float dist = Vector3.Distance(startPos, endPos);

		step = endPos - startPos;
		stack = new GameObject(); // Create a gameObject to hold the stack
		stack.name = "Pos to Pos Wall";
		stack.transform.position = nextPos; // Place stack at nextPos

		for (int i = 0; i < dist; i++){
			newObj = GameObject.CreatePrimitive(PrimitiveType.Cube); // Creates a primative cube

			newObj.GetComponent<MeshRenderer> ().material.color = Color.white; //Sets its color to black
		
			newObj.transform.position = nextPos; // moves it to nextPos
			newObj.name = "Step " + i;
			newObj.transform.parent = stack.transform; // Makes it a child of the new game object named stack
			nextPos += step.normalized; 
		}
		return stack;
	}
	//transform.RotateAround (sphereObject.position, Vector3.up, 20 * Time.deltaTime);

	GameObject ring;
	float angle;

	public GameObject Ring ( float radius, float deltaAngle, int numUnits) {

		nextPos = Vector3.zero;
		ring = new GameObject(); // Create a gameObject to hold the stack
		ring.name = "Simple Ring";		
		ring.transform.position = nextPos; // Place stack at nextPos
		angle = 0;
		Vector3 center = new Vector3(0f, 0f, radius);
		for (int i = 0; i < numUnits; i++){
			newObj = GameObject.CreatePrimitive(PrimitiveType.Cube); // Creates a primative cube
			newObj.GetComponent<MeshRenderer>().material.color = Color.black; //Sets its color to black
			newObj.transform.RotateAround( center, Vector3.up, angle );
			angle += deltaAngle;
			newObj.name = "Step " + i;
			newObj.transform.parent = ring.transform; // Makes it a child of the new game object named stack

		}
		return ring;
	}




}
