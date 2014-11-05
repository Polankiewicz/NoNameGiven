using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	public GameObject Bullet;
	public float BulletSpeed;
	public int WeaponStyle = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown ("Fire1") && WeaponStyle == 1)
		{
			Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
			Vector3 lookPosition = Camera.main.ScreenToWorldPoint(mousePosition);
			lookPosition = lookPosition - transform.position;
			float angle = Mathf.Atan2 (lookPosition.y, lookPosition.x) * Mathf.Rad2Deg;
			GameObject b1 = Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation) as GameObject;
			b1.transform.Rotate(new Vector3(0,0,-90));
			b1.rigidbody.velocity = new Vector3(Mathf.Cos(angle*Mathf.Deg2Rad), Mathf.Sin (angle*Mathf.Deg2Rad),0)*BulletSpeed;
		}

	}
}
