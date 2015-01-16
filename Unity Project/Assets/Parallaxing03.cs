using UnityEngine;
using System.Collections;

public class Parallaxing03 : MonoBehaviour {
	public Transform mainCam;
	public float i;
	
	void Update ()
	{
		transform.position = new Vector3 (i + mainCam.position.x / 15f, transform.position.y, transform.position.z);
	}
}
