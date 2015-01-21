using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	string deathMessage = UserName + " died ;(";
	bool showDeathMessage = false;
	public GUIStyle deathMessageStyle;
	public GameObject mainCam;
	
	public void GetUserName ()
	{
		GameObject go = GameObject.Find("GlobalSettings");
		Settings settings = (Settings) go.GetComponent(typeof(Settings));

		string UserName = settings.UserName;
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
				GUI.Label (new Rect (0,0,100,50), deathMessage, deathMessageStyle);
			}
		}
}
