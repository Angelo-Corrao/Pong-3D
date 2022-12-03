using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	private Rigidbody rb;
	private Vector3 direction;
	public float speed = 300.0f;
	public float speedMultiplier = 15.0f;

	private void Awake() {
		rb = GetComponent<Rigidbody>();
	}

	// Start is called before the first frame update
	void Start() {
		AddStartingForce();
	}

	// Update is called once per frame
	void Update() {
		
	}

	private void OnCollisionEnter(Collision collision) {
		/*if (collision.gameObject.CompareTag("Armor")) {
			collision.gameObject.SetActive(false);
		}*/

		if (collision.gameObject.CompareTag("Paddle1")) {
			if(rb.velocity.y < 0)
				rb.AddForce(new Vector3(1, -1, 0) * speedMultiplier);
			else
				rb.AddForce(new Vector3(1, 1, 0) * speedMultiplier);
		}

		if (collision.gameObject.CompareTag("Paddle2")) {
			if (rb.velocity.y < 0)
				rb.AddForce(new Vector3(-1, -1, 0) * speedMultiplier);
			else
				rb.AddForce(new Vector3(-1, 1, 0) * speedMultiplier);
		}
	}

	public void AddStartingForce() {
		float x = Random.value < 0.5f ? -1.0f : 1.0f;
		float y = Random.value < 0.5f ? Random.Range(-1.0f, 0.0f)
									  : Random.Range(0.0f, 1.0f);
		direction = new Vector3(x, y, 0);

		rb.AddForce(direction * speed);
	}

	public void ResetPosition() {
		rb.position= Vector3.zero;
		rb.velocity = Vector3.zero;
	}

	public void AddForce(Vector3 force) {
		rb.AddForce(force);
	}
}
