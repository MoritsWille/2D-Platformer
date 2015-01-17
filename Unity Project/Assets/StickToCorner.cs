using UnityEngine;
using System.Collections;

public class StickToCorner : MonoBehaviour {

	public Transform mainCam; 
	public float xPos;
	public float yPos;
	Transform pos = new Vector3(mainCam.camera.pixelWidth - xPos, mainCam.camera.pixelHeight - yPos, 0);

	void Update () {
		transform.position = pos;
	}