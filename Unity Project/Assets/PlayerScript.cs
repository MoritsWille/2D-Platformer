using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float respawnX;
	public float respawnY;
	public float respawnZ;
	public float minYPos;
	string deathMessage = "Welcome to hell!";
	bool showDeathMessage = false;
	
	void OnGUI()
	{
		if (showDeathMessage == true)
		{
			deathMessage = GUI.TextField (new Rect (10, 10, 200, 20), deathMessage);
		}
	}
	
	void Update ()
	{
		if (transform.position.y < minYPos)
		{
			showDeathMessage = true;
			transform.position = new Vector3 (respawnX, respawnY, respawnZ);
		}
	}
}
