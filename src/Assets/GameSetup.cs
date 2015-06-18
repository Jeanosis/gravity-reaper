using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour {
	public Camera MainCamera;
	public Transform Hero;
	public RectTransform leftSlider, rightSlider;
	public BoxCollider2D LeftWall, RightWall;

	void Start () {
		var offset = 5.0F;
		var width = (float)Screen.width;
		var height = (float)Screen.height;

		LeftWall.size = new Vector2 (1F, MainCamera.ScreenToWorldPoint (new Vector3 (0F, Screen.height * 2F, 0F)).y);
		LeftWall.offset = new Vector2 (-MainCamera.ScreenToWorldPoint (new Vector3 (Screen.width, 0F, 0F)).x - 0.5F, 0F);

		RightWall.size = LeftWall.size;
		RightWall.offset = new Vector2 (-LeftWall.offset.x, LeftWall.offset.y);

		Hero.position = new Vector3 (Hero.position.x, MainCamera.ScreenToWorldPoint (new Vector3 (0F, 70F, 0F)).y, 0F);

		leftSlider.sizeDelta = new Vector2 (width / 2.0F - (2 * offset), 20);
		leftSlider.position = new Vector3((leftSlider.sizeDelta.x / 2.0F) + offset, (leftSlider.sizeDelta.y / 2.0F) + offset);

		rightSlider.sizeDelta = leftSlider.sizeDelta;
		rightSlider.position = new Vector3(width - leftSlider.position.x, leftSlider.position.y);
		//offset + (leftSlider.sizeDelta.x / 2.0F) - 0.5F, offset + (leftSlider.sizeDelta.y / 2.0F) - 0.5F);
		//leftSlider.sca = new Vector2 (-MainCamera.ScreenToWorldPoint (new Vector3 (Screen.width, 0F, 0F)).x - 0.5F, 0F);
	}
}
