using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	float startTime;

	// Use this for initialization
	void Start () {
		startTime = Time.realtimeSinceStartup;
	}
	
	// Update is called once per frame
	void Update () {
		if ((Time.realtimeSinceStartup - startTime) > 1)
		{
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter(Collider c)
	{
		if ((c.collider.tag == "wall") || (c.collider.tag == "enemy"))
		{
			Destroy(gameObject);
		}
	}
}
