using UnityEngine;

public class BreakableWall : MonoBehaviour
{
	public int totHitNum = 3;
	private Renderer wallRenderer;

	private void Start() {
		wallRenderer = this.GetComponent<Renderer>();
	}

	private void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.CompareTag("Ball")) {
			totHitNum--;

			switch (totHitNum) {
				case 2:
					wallRenderer.material.color = Color.yellow;
					break;
				case 1:
					wallRenderer.material.color = Color.white;
					break;
				case 0:
					this.gameObject.SetActive(false);
					break;
			}
		}
	}
}
