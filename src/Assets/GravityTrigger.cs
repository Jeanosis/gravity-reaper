using UnityEngine;
using System.Collections;

public class GravityTrigger : MonoBehaviour {
	public Rigidbody2D Hero;

	void OnTriggerEnter2D(Collider2D other) {
		Hero.velocity = new Vector2 (Hero.velocity.x * 0.75F, 0F);
	}
	void OnTriggerExit2D(Collider2D other) {
		Physics2D.gravity = new Vector2 (-Physics2D.gravity.x, 0F);
	}
}
