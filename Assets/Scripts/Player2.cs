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
	}

	private void FixedUpdate() {
		transform.position += direction * speed * Time.deltaTime;
		//rb.velocity = direction * speed;
		/*if (direction.sqrMagnitude != 0)
			rb.AddForce(direction * speed);*/
	}
}
