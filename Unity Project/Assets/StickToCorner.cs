using UnityEngine;
using System.Collections;

public class StickToCorner : MonoBehaviour {
	
	public Transform mainCam; 
	public float xPos;
	public float yPos;
	
	void Start () {
		transform.position = new Vector3(-mainCam.camera.pixelWidth + mainCam.camera.pixelWidth + xPos, mainCam.camera.pixelHeight - yPos, 0);
	}
}