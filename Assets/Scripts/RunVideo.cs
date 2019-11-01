using UnityEngine;
using System.Collections;

public class RunVideo : MonoBehaviour {

	public MovieTexture movTexture;
	private int movieName = 1;
	bool loop;
	// Use this for initialization
	void Start () {
		GetComponent<Renderer> ().material.mainTexture = movTexture;
		movTexture.Play ();
		movTexture.loop = true;
		print ("Start");

	}
	
	// Update is called once per frame
	void Update () {

	}
}
