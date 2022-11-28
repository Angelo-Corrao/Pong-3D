using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : Paddle {

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		if (Input.GetKey(KeyCode.UpArrow)) {
			if (transform.position.y < 4.2)
				transform.position += Vector3.up * speed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.DownArrow)) {
			if (transform.position.y > -4.2)
				transform.position += Vector3.down * speed * Time.deltaTime;
		}
	}
}
