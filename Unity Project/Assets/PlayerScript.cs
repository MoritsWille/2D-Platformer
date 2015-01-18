﻿using UnityEngine;
using System.Collections;
using System.Timers;

public class PlayerScript : MonoBehaviour {

	public float respawnX;
	public float respawnY;
	public float respawnZ;
	public float minYPos;
	string deathMessage = "Welcome to hell!";
	bool showDeathMessage = false;
	public GUIStyle screenMessageSize;

	void start ()
	{

	}

	void OnGUI()
	{
		if (showDeathMessage == true)
		{
			GUI.Label (new Rect (600, 100, 200, 20), deathMessage, screenMessageSize);
		}
	}
	IEnumerator wait()
	{
		yield return new WaitForSeconds (2f);
		showDeathMessage = false;
	}
	
	void Update ()
	{
		if (transform.position.y < -5)
		{
			showDeathMessage = true;
			StartCoroutine("wait");
			if (transform.position.y < minYPos)
			{
				transform.position = new Vector3 (respawnX, respawnY, respawnZ);
			}
		}
	}
}