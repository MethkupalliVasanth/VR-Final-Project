using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildWall : MonoBehaviour {

	public GameObject blockPrefab;
	public int numStacks;

	// Use this for initialization
	void Start () {
		// Our for loop for building stacks
		for (int i = 0; i < numStacks; i++) {
			// Use the following line to print where we are in the loop
			Debug.Log("BuildWall: Building stack " + (i+1).ToString() + " of " + numStacks.ToString());

			BuildStack ();

			// Make sure to reset the startin position of the stack
			// In class, we stored our starting position as nextPos
			// ...
		}
	}

	// Use this to build a stack
	void BuildStack() {
		Debug.Log ("BuildWall: Stack built!");

		// Put your code here that builds a single stack
		// ...
	}
}
