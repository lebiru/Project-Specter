using UnityEngine;
using System.Collections;

public class EnemyTurretShoot : MonoBehaviour {

	public GameObject bullet;
	public float fireSpeed = 2.0f;
	private bool allowFire = true;
	
	void Update () 
	{
		if (allowFire) 
		{
			Fire();
			audio.Play();
		}
	}
	
	void Fire()
	{
		allowFire = false;
		Vector3 bulletRotation = rigidbody.transform.rotation.eulerAngles;
		bulletRotation.x = 0.0f;
		bulletRotation.y = 0.0f;
		bulletRotation.z += 45f;
		Instantiate (bullet, transform.position, Quaternion.Euler(bulletRotation));
		Invoke ("AllowFire", fireSpeed);
	}
	
	void AllowFire()
	{
		allowFire = true;
	}
}
