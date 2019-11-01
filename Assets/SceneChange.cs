using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {

	public GameObject one;
	public GameObject two;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			OVRInput.Update ();
			if (OVRInput.Get (OVRInput.Button.DpadRight)){
				one.SetActive (false);
				two.SetActive (true);
			}
	}
}
