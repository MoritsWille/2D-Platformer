using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	string deathMessage;
	bool showDeathMessage = false;
	public GUIStyle deathMessageStyle;
	public GameObject mainCam;
	
	void Start ()
	{
		GameObject go = GameObject.Find("GlobalSettings");
		Settings settings = (Settings) go.GetComponent(typeof(Settings));

		if (settings.UserName == "")
		{
			deathMessage = "Player died ;(";
		}
		else 
		{
			deathMessage = settings.UserName + " died ;(";
		}
	}

	void Update ()
	{
		if (transform.position.y < -15)
		{
			showDeathMessage = true;
			if (transform.position.y < -40)
			{
				transform.position = new Vector3 (7.04f, 0, 0);
				showDeathMessage = false;
			}
		}
	}

	void OnGUI ()
		{
			if (showDeathMessage == true)
			{
			GUI.Label (new Rect (mainCam.camera.pixelWidth / 2, mainCam.camera.pixelHeight / 2.5f, 100,50), deathMessage, deathMessageStyle);
			}
		}
}
