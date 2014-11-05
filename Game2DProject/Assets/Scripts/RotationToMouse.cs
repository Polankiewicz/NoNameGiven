using UnityEngine;
using System.Collections;

public class RotationToMouse : MonoBehaviour {
	public int rotationoffset;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0);
		Vector3 lookPosition = Camera.main.ScreenToWorldPoint (mousePosition);
		lookPosition = lookPosition - transform.position;
		float angle = Mathf.Atan2 (lookPosition.y, lookPosition.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis (angle * rotationoffset, Vector3.forward);
	}
}
