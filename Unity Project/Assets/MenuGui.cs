using UnityEngine;
using System.Collections;

public class MenuGui : MonoBehaviour
{

	public void Test()
	{
		Application.LoadLevel("2dPlatformer");
	}

	public void GotoMainMenu ()
	{
		Application.LoadLevel ("Menu");
	}
	public void GotoOpTions ()
	{
		Application.LoadLevel ("Options");
	}
}