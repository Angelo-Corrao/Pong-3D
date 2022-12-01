using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	private Rigidbody rb;
	public float speed = 300.0f;

	private void Awake() {
		rb = GetComponent<Rigidbody>();
	}

	// Start is called before the first frame update
	void Start() {
		float x = Random.value < 0.5f ? -1.0f : 1.0f;
		float y = Random.value < 0.5f ? Random.Range(-1.0f, 0.0f)
									 : Random.Range(0.0f, 1.0f);
		Vector3 direction = new Vector3(x, y, 0);

		rb.AddForce(direction * speed);
	}

	// Update is called once per frame
	void Update() {
		
	}

	private void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.CompareTag("LeftGoal"))
			Debug.Log("P1");
		if (collision.gameObject.CompareTag("RightGoal"))
			Debug.Log("P2");
		if (collision.gameObject.CompareTag("Armour"))
			collision.gameObject.SetActive(false);
	}
}
