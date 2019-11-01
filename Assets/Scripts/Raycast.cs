using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour 
{

	private RaycastHit vision;
	private Rigidbody grabbedObject;
	public float rayLength;
	private bool isGrabbed;
	//private bool stop;
	private Vector3 originalPosition;

	// Use this for initialization
	void Start () 
	{
		isGrabbed = false;
		//stop = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Debug.DrawRay (Camera.main.transform.position, Camera.main.transform.forward * rayLength, Color.red, 0.5f);
		Debug.Log (vision.distance);
		if (Physics.Raycast (Camera.main.transform.position, Camera.main.transform.forward, out vision, rayLength)) 
		{
			//Debug.Log (vision.collider.name);
			if (isGrabbed == false)
			{
				originalPosition = vision.rigidbody.position;
			}
			isGrabbed = true;
			grabbedObject = vision.rigidbody;
		}

		//if (vision.distance < 2.0f)
		//{
		//	stop = true;
		//}

		if ((!Physics.Raycast (Camera.main.transform.position, Camera.main.transform.forward, out vision, rayLength) && isGrabbed == true))
		{
			Debug.Log("Goes to original");
			grabbedObject.position = originalPosition;
			isGrabbed = false;
		}

		if (isGrabbed)// || stop == true)
		{
			grabbedObject.position = Vector3.MoveTowards (grabbedObject.position, new Vector3(0,0,0) +
				originalPosition.normalized + originalPosition.normalized + 
				originalPosition.normalized, 2 * Time.deltaTime);
		}
	}

}
