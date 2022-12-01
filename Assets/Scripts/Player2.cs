using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : Paddle {

	private Vector3 direction;

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		direction = new Vector3(0, Input.GetAxisRaw("Vertical2"), 0);
		Vector3 newpos = transform.position + direction * speed * Time.deltaTime;
		newpos.y = Mathf.Clamp(newpos.y, -4.2f, 4.2f);
		transform.position = newpos;
	}
}
