using UnityEngine;
using System.Collections;
using System;

public class ControlsScript : MonoBehaviour {
	public KeyCode MoveLeft, MoveRight;
	protected float Speed = 0.04F;
	
	private float time = 0;
	public float amplitude = 1.6F, frequency = 2.0F, rad = (2.0F * Mathf.PI) / 360.0F, min = 100, max = -100;

	void Start(){
		transform.position = new Vector3 (0.9F, transform.position.y, transform.position.z);
		//rigidbody2D.velocity = new Vector2((-frequency) * amplitude * Mathf.Sin (rad * (frequency * time /*+ 90*/)), 0);
		//time = (float)Math.PI / frequency / Time.deltaTime / 2.0F;//Convert.ToInt32(Mathf.PI / frequency);
		//Debug.Log (time);
	}

	void Update () {
		if (Input.GetKey (MoveLeft)) {
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x - Speed, rigidbody2D.velocity.y);
		} else if (Input.GetKey (MoveRight)) {
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x + Speed, rigidbody2D.velocity.y);
		}

		var sin = Mathf.Sin (rad * (frequency * time));
		/*if (sin > 0.95F || sin == -1 || sin == 0)
			Debug.Log (String.Format("{0}, {1}, {2}", sin, transform.position.x, time));*/
		//if (transform.position.x  > amplitude / 2 || transform.position.x < -amplitude / 2)
		//	Debug.Log (String.Format("{0}, {1}, {2}", sin, transform.position.x, time));

		rigidbody2D.velocity = new Vector2((-frequency) * amplitude * Mathf.Sin (rad * frequency * time), 0);

		if (transform.position.x < min)
			min = transform.position.x;
		if (transform.position.x > -min)
			max = transform.position.x;
		Debug.Log (String.Format("{0}, {1}", min, max));

		time += 1;// / Time.deltaTime;*/
	}
}
