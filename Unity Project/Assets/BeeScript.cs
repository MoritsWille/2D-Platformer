using UnityEngine;
using System.Collections;

public class BeeScript : MonoBehaviour {

	public Transform Player;
	float beePosX;
	float beePosY;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject go = GameObject.Find ("Player");
		PlatformerCharacter2D platformerCharacter2D = (PlatformerCharacter2D)go.GetComponent (typeof(PlatformerCharacter2D));

		if (platformerCharacter2D.facingRight == true)
		{
			transform.localScale = new Vector3(-0.25f, 0.25f, 1);
			transform.position = new Vector3 (beePosX, beePosY, 1);
		}
		else
		{
			transform.localScale = new Vector3(0.25f, 0.25f, 1);
			transform.position = new Vector3 (beePosX, beePosY, 1);
		}

		if (Player.position.x > transform.position.x + 1f)
		{
			beePosX = beePosX + 0.1f;
		}
		else if (Player.position.x < transform.position.x - 1f)
		{
			beePosX = beePosX - 0.1f;
		}

		if (Player.position.y > transform.position.y - 1)
		{
			beePosY = beePosY + 0.1f;
		}
		else if (Player.position.y < transform.position.y - 1)
		{
			beePosY = beePosY - 0.1f;
		}
		if (Player.position.y == transform.position.y - 1)
		{
			beePosY = Player.position.y + 1;
		}
	}
}
