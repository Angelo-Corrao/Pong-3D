using UnityEngine;
using UnityEngine.Events;

public class ScoringZone : MonoBehaviour
{
	public UnityEvent onCollisionEnter;

	private void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.CompareTag("Ball"))
			onCollisionEnter.Invoke();
	}
}
