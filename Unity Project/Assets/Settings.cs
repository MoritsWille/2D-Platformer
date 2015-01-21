using UnityEngine;
using System.Collections;
using System.IO;

public class Settings : MonoBehaviour {

	public string UserName;
	string path = @"Data\NickName.txt";

	// Use this for initialization
	void Start () {

		using (StreamReader sr = File.OpenText(path) )
		{
			UserName = sr.ReadLine();
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		using (StreamWriter sw = File.CreateText(path))
		{
			sw.WriteLine(UserName);
		}
	}
	void Awake() {

		DontDestroyOnLoad(transform.gameObject);

	}
}
