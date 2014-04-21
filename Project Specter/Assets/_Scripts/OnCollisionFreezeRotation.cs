using UnityEngine;
using System.Collections;

public class OnCollisionFreezeRotation : MonoBehaviour {

	void OnCollisionEnter()
	{
		rigidbody.freezeRotation = true;
	}
}
