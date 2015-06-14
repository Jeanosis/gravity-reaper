using UnityEngine;
using System.Collections;
using System;

public class ControlsScript : MonoBehaviour {
	public KeyCode MoveLeft, MoveRight;
	
	private float time = 0;
	private float amplitude = 1.6F, frequency = 2.0F, rad = (2.0F * Mathf.PI) / 360.0F, min = 100, max = -100;

	void Start(){
		transform.position = new Vector3 (0.9F, transform.position.y, transform.position.z);
	}

	void Update () {
		if (Input.GetKey (MoveLeft)) {
			amplitude += 0.05F;
		} else if (Input.GetKey (MoveRight)) {
			amplitude -= 0.05F;
		}

		var sin = Mathf.Sin (rad * (frequency * time));

		GetComponent<Rigidbody2D>().velocity = new Vector2((-frequency) * amplitude * Mathf.Sin (rad * frequency * time), 0);

		time += 1;
	}
}
