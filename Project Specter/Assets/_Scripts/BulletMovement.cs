using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour {

	public float speed = 1.0f;

	void Update () 
	{
		rigidbody.transform.position += transform.up * speed * Time.deltaTime;	
	}
}
