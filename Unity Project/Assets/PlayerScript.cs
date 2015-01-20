using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float respawnX;
	public float respawnY;
	public float respawnZ;
	public float minYPos;
	public Transform mainCam;
	string deathMessage;
	bool showDeathMessage = false;
	public GUIStyle screenMessageSize;

	public void setDeathMessage ()
	{
		GameObject go = GameObject.Find("GlobalSettings");
		Settings settings = (Settings)go.GetComponent (typeof(Settings));
		
		deathMessage = settings.UserName + " died";

		Debug.Log (deathMessage);

	}

	void OnGUI()
	{
		if (showDeathMessage == true)
		{
			GUI.Label (new Rect (mainCam.camera.pixelWidth / 2, mainCam.camera.pixelHeight / 2, 200, 20), deathMessage, screenMessageSize);
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