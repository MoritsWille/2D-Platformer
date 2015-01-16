using UnityEngine;
using System.Collections;

public class Parallaxing02 : MonoBehaviour {
	public Transform mainCam;
	public float i;
	
	void Update ()
	{
		transform.position = new Vector3 (i + mainCam.position.x / -7f, transform.position.y, transform.position.z);
	}
}
