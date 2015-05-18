using UnityEngine;
using System.Collections;

public class GravityTrigger : MonoBehaviour {
	public GameObject Hero;

	void OnTriggerEnter2D(Collider2D other) {
		var amplitude = Hero.GetComponent<ControlsScript> ().amplitude;

		amplitude = 0;
		Debug.Log ("lol");
		//Hero.velocity = new Vector2 (Hero.velocity.x * 0.75F, 0F);
	}
	void OnTriggerExit2D(Collider2D other) {
		Physics2D.gravity = new Vector2 (-Physics2D.gravity.x, 0F);
	}
}
