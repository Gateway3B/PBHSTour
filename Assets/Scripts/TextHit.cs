using UnityEngine;
using System.Collections;


public class TextHit : MonoBehaviour {

	private bool selected;
	public GameObject printer;

	// Use this for initialization
	void Start () {
		selected = false;
	}
	// Update is called once per frame
	void Update () {
		OVRInput.Update ();
		if (OVRInput.Get (OVRInput.Button.One) && selected) {
			Debug.Log ("worked");
			printer.transform.SendMessage ("animate");
		}
	}

	public void SelectedByRay()
	{
		Renderer rend = GetComponent<Renderer> ();
		rend.GetComponent<TextMesh> ().color = Color.red;
		Debug.Log ("Selected");

		selected = true;
	}

	public void DeselectedByRay()
	{
		Renderer rend = GetComponent<Renderer> ();
		rend.GetComponent<TextMesh> ().color = Color.white;
		selected = false;
		Debug.Log ("Deselected");
	}
}
