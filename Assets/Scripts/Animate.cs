using UnityEngine;
using System.Collections;

public class Animate : MonoBehaviour {

	public Vector3 originalPosition;
	private bool run;

	// Use this for initialization
	void Start () {
		originalPosition = this.transform.position;
		run = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (run) {
			this.transform.position = Vector3.MoveTowards (this.transform.position, new Vector3 (0, -1, 0) + originalPosition.normalized + originalPosition.normalized + originalPosition.normalized, 2 * Time.deltaTime);
		}
	}

	IEnumerator animate()
	{
		run = true;
		Debug.Log("animated");
		yield return new WaitForSeconds (10);
		Debug.Log(run);
		run = false;
		Debug.Log(run);
		this.transform.position = originalPosition;
	}


		

}
