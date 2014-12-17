using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public Transform target;
	public Vector3 distance = new Vector3(0f, 2f, -5f);

	public float positionDamping = 2.0f;
	public float rotateDamping = 2.0f;


	private Transform thisTransform;


	// Use this for initialization
	void Start () 
	{
		thisTransform = transform;

	}
	
	// Update is called once per frame
	void LateUpdate () 
	{

		if (!target) 
		{
			return;
		}

		// controling camera position
		Vector3 wantedPosition = target.position + (target.rotation * distance);
		Vector3 currentPosition = Vector3.Lerp (thisTransform.position, wantedPosition, positionDamping * Time.deltaTime);
		thisTransform.position = currentPosition;

		// controling camera rotation
		Quaternion wantedRotation = Quaternion.LookRotation (target.position - thisTransform.position, target.up);
		thisTransform.rotation = wantedRotation;
	}
}
