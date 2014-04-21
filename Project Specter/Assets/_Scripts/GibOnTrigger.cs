using UnityEngine;
using System.Collections;

public class GibOnTrigger : MonoBehaviour 
{
	public GameObject gib = null;
	
	void OnTriggerEnter () 
	{
		if(gib != null)
		{
			Instantiate (gib, transform.position, gib.transform.rotation);
		}
		Destroy (gameObject);
	}
}
