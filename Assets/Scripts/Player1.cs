using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : Paddle {

	private Vector3 direction;

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		/*if (Input.GetKey(KeyCode.W)) {
			if (transform.position.y < 4.2)
				transform.position += Vector3.up * speed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.S)) {
			if (transform.position.y > -4.2)
				transform.position += Vector3.down * speed * Time.deltaTime;
		}*/
		direction = new Vector3(0, Input.GetAxisRaw("Vertical"), 0);
		Vector3 newpos = transform.position + direction * speed * Time.deltaTime;
		newpos.y = Mathf.Clamp(newpos.y, -4.2f, 4.2f);
		transform.position = newpos;
	}

	private void FixedUpdate() {
		//rb.MovePosition(direction);
		//rb.velocity = direction * speed;
		/*if (direction.sqrMagnitude != 0)
			rb.AddForce(direction * speed);*/
	}
}
