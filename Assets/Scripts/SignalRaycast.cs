using UnityEngine;
using System.Collections;

public class SignalRaycast : MonoBehaviour{
	
	private RaycastHit vision;
	private RaycastHit LastObject;
	public float rayLength;
	private bool ray;
	private bool hit = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawRay (Camera.main.transform.position, Camera.main.transform.forward * rayLength, Color.red, 0.5f);
		ray = Physics.Raycast (Camera.main.transform.position, Camera.main.transform.forward, out vision, rayLength);
		if (ray) {
			LastObject = vision;
			Debug.Log (vision.collider.name);
			LastObject.transform.SendMessage ("SelectedByRay");
			hit = true;
			//print ("Selected");
		} else {
			if (hit)
			{
				LastObject.transform.SendMessage ("DeselectedByRay");
				hit = false;
			}
			//print ("Deselected");
		}
		Debug.DrawRay (Camera.main.transform.position, Camera.main.transform.forward * rayLength, Color.red, 0.5f);
		/*
		TextHit cast = GetComponent<TextHit>();
		ray = Physics.Raycast (Camera.main.transform.position, Camera.main.transform.forward, out vision, rayLength);
		if (ray) {
			LastObject = vision;
			Debug.Log (vision.collider.name);
			cast.SelectedByRay();
			print ("Selected");
		} else {
			
			cast.DeselectedByRay ();
			print ("Deselected");
		}
		*/
	}
}
