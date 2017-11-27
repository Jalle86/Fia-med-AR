using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCircles : MonoBehaviour {

	public float distance;
	public GameObject circle;
	public Transform board;
	int num = 39;

	// Use this for initialization
	void Start () {
		GameObject go;
		go = GenerateQuartile (Vector3.right, null, "Green");
		go = GenerateQuartile (Vector3.forward, go, "Red");
		go = GenerateQuartile (-Vector3.right, go, "Yellow");
		go = GenerateQuartile (-Vector3.forward, go, "Blue");
	}

	GameObject GenerateQuartile(Vector3 direction, GameObject link, string color) {
		GameObject go = null;
		GameObject previous = link;
		Vector3 position = 0.1f * Vector3.up;
		Quaternion rotation = Quaternion.AngleAxis(-90, Vector3.up);
		for (int i = 1; i <= 4; i++) {
			position += distance * direction;
			go = Instantiate (circle, position, circle.transform.rotation, board);
			go.name = color + ' ' + i;
		}

		position += distance * direction;
		go = Instantiate (circle, position, circle.transform.rotation, board);
		go.name = "Circle " + (num--).ToString();

		direction = rotation * direction;
		position += distance * direction;
		go = Instantiate (circle, position, circle.transform.rotation, board);
		go.name = "Circle " + (num--).ToString();

		direction = rotation * direction;
		for (int i = 0; i < 4; i++) {
			position += distance * direction;
			go = Instantiate (circle, position, circle.transform.rotation, board);
			go.name = "Circle " + (num--).ToString();
		}

		direction = rotation * -direction;
		for (int i = 0; i < 4; i++) {
			position += distance * direction;
			go = Instantiate (circle, position, circle.transform.rotation, board);
			go.name = "Circle " + (num--).ToString();
		}

		return go;
	}

	// Update is called once per frame
	void Update () {
	}
}
