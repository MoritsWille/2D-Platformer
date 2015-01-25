using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UserName : MonoBehaviour {

	public InputField InputField;
	public Slider Slider;

	void Start()
	{

		GetUserName();

	}
	void Update()
	{
		GameObject go = GameObject.Find ("GlobalSettings");
		Settings settings = (Settings)go.GetComponent (typeof(Settings));

		settings.MVolume = Slider.value;
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
