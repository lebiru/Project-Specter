using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject bullet;
	public float fireSpeed = 0.05f;
	private bool allowFire = true;

	void Update () 
	{
		if (Input.GetButton ("Fire1") && allowFire) 
		{
			Fire();
			audio.Play();
		}
	}

	void Fire()
	{
		allowFire = false;
		Instantiate (bullet, transform.position, transform.rotation);
		Invoke ("AllowFire", fireSpeed);
	}

	void AllowFire()
	{
		allowFire = true;
	}
}
