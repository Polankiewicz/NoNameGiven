using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	int Hp = 5;
	int EnemySpeed = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 playerPosition = GameObject.Find ("Player").transform.position;
		Vector3 lookPosition = playerPosition;
		lookPosition = lookPosition - transform.position;
		float angle = Mathf.Atan2 (lookPosition.y, lookPosition.x) * Mathf.Rad2Deg;
		gameObject.rigidbody.velocity = new Vector3 (Mathf.Cos (angle * Mathf.Deg2Rad), Mathf.Sin (angle * Mathf.Deg2Rad), 0) * EnemySpeed;

		if (Hp == 0 || Hp < 0) 
		{
			Destroy(gameObject);
		}

	}

	void OnTriggerEnter(Collider c)
	{
		if (c.tag == "bullet")
		{
			Hp = Hp - 1;
		}

	}

}
