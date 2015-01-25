using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	
	public KeyCode jump;
	bool i = false;
	public Sprite walk, idle;

	
	void Jump () {
	}
	
	void Update () {
		transform.rotation = new Quaternion (0, 0, 0, 0);

		if (Input.GetKey("w") && i == false)
		{
			i = true;
			transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, 0);
			i = false;
		}

		if (Input.GetKey("d"))
		{
			gameObject.GetComponent<SpriteRenderer>().sprite = walk;
			transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, 0);
			transform.localScale = new Vector3(0.5f, 0.5f, 1);
		}

		if (Input.GetKey("a"))
		{
			gameObject.GetComponent<SpriteRenderer>().sprite = walk;
			transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, 0);
			transform.localScale = new Vector3(-0.5f, 0.5f, 1);
		}

	}
}