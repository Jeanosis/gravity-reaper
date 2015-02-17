using UnityEngine;
using System.Collections;

public class ControlsScript : MonoBehaviour {
	public KeyCode MoveLeft, MoveRight;
	protected float Speed = 0.04F;

	void Update () {
		if (Input.GetKey (MoveLeft)) {
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x - Speed, rigidbody2D.velocity.y);
		} else if (Input.GetKey (MoveRight)) {
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x + Speed, rigidbody2D.velocity.y);
		}
	}
}
