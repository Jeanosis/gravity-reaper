using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class ControlsScript : MonoBehaviour {
	public KeyCode MoveLeft, MoveRight;
	public Slider leftSlider, rightSlider;

	private float time = 0;
	private static float maxAmplitude = 1.6F;
	private float amplitude = maxAmplitude / 2.0F, frequency = 2.0F, rad = (2.0F * Mathf.PI) / 360.0F, min = 100, max = -100;

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

	public void OnLeftValueChanged()
	{
		/*rightSlider.value = 1.0F - leftSlider.value;
		amplitude = maxAmplitude * leftSlider.value;*/
		OnValueChanged (rightSlider, leftSlider);
	}

	public void OnRightValueChanged()
	{
		/*leftSlider.value = 1.0F - rightSlider.value;
		amplitude = maxAmplitude * leftSlider.value;*/
		OnValueChanged (leftSlider, rightSlider);
	}

	private void OnValueChanged(Slider first, Slider second)
	{
		first.value = 1.0F - second.value;
		amplitude = maxAmplitude * first.value;

	}
}
