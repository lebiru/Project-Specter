using UnityEngine;
using System.Collections;

public class TurnTowardsPlayer : MonoBehaviour {

	public GameObject player;
	public float rotationSpeed = 5.0f;

	void FixedUpdate () 
	{
		rigidbody.transform.LookAt (player.rigidbody.transform.position, Vector3.back);
	}
}
