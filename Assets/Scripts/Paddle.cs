using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Paddle : MonoBehaviour {

	protected Rigidbody rb;
	[SerializeField]
	protected float speed = 10.0f;

	private void Awake() {
		rb = GetComponent<Rigidbody>();
	}

	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {

	}
}
