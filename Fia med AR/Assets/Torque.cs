using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : MonoBehaviour {

	Rigidbody rb;
	bool moving;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (moving && rb.IsSleeping()) {
			moving = false;
			Debug.Log (SideUp ());
		}
	}

	public int SideUp() {
		Vector3[] sides = new Vector3[] {
			transform.forward,
			transform.up,
			-transform.right,
			transform.right,
			-transform.up,
			-transform.forward
		};

		for (int i = 0; i < 6; i++) {
			if (Vector3.Angle (Vector3.up, sides [i]) < 0.5f)
				return i + 1;
		}

		return 0;
	}

	void OnMouseDown() {
		gameObject.AddComponent<cakeslice.Outline> ();
	}

	void OnMouseUp() {
		Destroy(GetComponent<cakeslice.Outline> ());
	}
}
