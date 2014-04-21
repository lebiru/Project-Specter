using UnityEngine;
using System.Collections;

public class EnemyBulletMovement : MonoBehaviour {

	public float speed = 1.0f;

	void Update () 
	{
		rigidbody.transform.position += transform.up * speed * Time.deltaTime;	
	}
}
