using UnityEngine;
using System.Collections;

public class GameSetup : MonoBehaviour {
	public Camera MainCamera;
	public Transform Hero;
	public BoxCollider2D LeftWall, RightWall;

	void Start () {
		LeftWall.size = new Vector2 (1F, MainCamera.ScreenToWorldPoint (new Vector3 (0F, Screen.height * 2F, 0F)).y);
		LeftWall.center = new Vector2 (-MainCamera.ScreenToWorldPoint (new Vector3 (Screen.width, 0F, 0F)).x - 0.5F, 0F);

		RightWall.size = LeftWall.size;
		RightWall.center = new Vector2 (-LeftWall.center.x, LeftWall.center.y);

		Hero.position = new Vector3 (Hero.position.x, MainCamera.ScreenToWorldPoint (new Vector3 (0F, 70F, 0F)).y, 0F);
	}
}
