using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UserName : MonoBehaviour {

	public InputField InputField;

	void Start()
	{

		GetUserName();

	}

	private void GetUserName ()
	{
		GameObject go = GameObject.Find("GlobalSettings");
		Settings settings = (Settings) go.GetComponent(typeof(Settings));

		InputField.text = settings.UserName;
	}

	public void SetUserName ()
	{
		GameObject go = GameObject.Find("GlobalSettings");
		Settings settings = (Settings) go.GetComponent(typeof(Settings));
		
		settings.UserName = InputField.text ;
	}
}
