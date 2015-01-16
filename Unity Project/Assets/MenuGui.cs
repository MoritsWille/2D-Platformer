using UnityEngine;
using System.Collections;

public class MenuGui : MonoBehaviour
{
	bool isIt = true;
	void OnGUI () {
		if (isIt == true)
		{
			if (GUI.Button (new Rect (25, 25, 100, 30), "non-Clicked", "label"))
			{
				GUI.Label (new Rect(25, 25, 100, 30), "CLicked");
				isIt = false;
			}			
		}
	}

}