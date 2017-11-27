using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;

public class Selected : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		cakeslice.Outline outline = gameObject.AddComponent<cakeslice.Outline> ();

	}
}
