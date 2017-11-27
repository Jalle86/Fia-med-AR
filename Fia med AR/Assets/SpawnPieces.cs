using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPieces : MonoBehaviour {

	public float radius;
	public Transform start;
	public GameObject piece;
	
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 4; i++) {
			GameObject go = Instantiate(piece);
			Vector3 pos = start.position + radius * new Vector3(Mathf.Cos(0.5f * Mathf.PI * i), 0, Mathf.Sin(0.5f * Mathf.PI * i));
			go.transform.position = pos + Vector3.up * piece.transform.localScale.y;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
