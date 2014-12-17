using UnityEngine;
using System.Collections;

public class LaserProjectile : MonoBehaviour {


	public float speed = 2f; // speed of laser
	public int damage = 25; // laser damage to other objects
	private Transform thisTransform; // cached transform for this projectile
	public Transform laserHitFXPrefab;


	// Use this for initialization
	void Start () 
	{
		thisTransform = transform;
	}
	
	// Update is called once per frame
	void Update () 
	{
		thisTransform.position += Time.deltaTime * speed * thisTransform.forward;
	}
}
