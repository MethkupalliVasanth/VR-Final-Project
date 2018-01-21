using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildTower : MonoBehaviour {

	public GameObject blockPrefab;
	public int numStacks;

	public Vector3 center = new Vector3 (0f, 0f, 0f); // The center around which we will rotate

	// Sample code to store the block we instatiate in start
	GameObject block;

	// Use this for initialization
	void Start () {
		// Sample code that instantiates a single block
		Vector3 pos = new Vector3(0f,0.5f,0f);
		pos.x = pos.x + 4f;
		block = Instantiate (blockPrefab, pos, Quaternion.identity);

		// Our for loop for building stacks
		for (int i = 0; i < numStacks; i++) {
			// Use the following line to print where we are in the loop
			Debug.Log("BuildTower: Building stack " + (i+1).ToString() + " of " + numStacks.ToString());

			BuildStack ();
		
			// Make sure to reset the startin position of the stack
			// In class, we stored our starting position as nextPos
			// ...
		}
	}

	// Use this to build a stack
	void BuildStack() {
		Debug.Log ("BuildTower: Stack built!");

		// Put your code here that builds a single stack
		//...
	}

	void FixedUpdate() {
		// Sample code that rotates the block we instatiated in Start around center
		block.transform.RotateAround (center, Vector3.up, 1.0f);
	}
}
