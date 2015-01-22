using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {


	void Jump () {
		if (Input.GetKey("space"))
		{
			for (int i = 0; i < 10)
			{
				transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, 0);
			}
		}
	}

	void Update () {
		if (Input.GetKey("w"))
		{
			transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y, 0);
		}
	
	}
}
