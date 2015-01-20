using UnityEngine;
using System.Collections;

public class Settings : MonoBehaviour {

	public string UserName;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void Awake() {

		DontDestroyOnLoad(transform.gameObject);

	}
}
