using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float thrustSpeed = 50.0f;

	void FixedUpdate()
	{

		//Rotation Analog Stick
		if(Mathf.Abs(Input.GetAxis ("HRS")) >= 0.2f || Mathf.Abs(Input.GetAxis("VRS")) >= 0.2f)
		{
			rigidbody.transform.rotation = Quaternion.Euler(0f, 0f, 
			    Mathf.Atan2 (Input.GetAxis("HRS") * -1, Input.GetAxis("VRS")) * Mathf.Rad2Deg);
		}

		//Rotation Mouse
		if(Input.GetAxis ("Mouse X") != 0 || Input.GetAxis ("Mouse Y") != 0)
		{
			Vector3 mousePosition = Input.mousePosition;
			mousePosition.z = 5.23f; //filler number
			Vector3 obj_pos = Camera.main.WorldToScreenPoint (transform.position);
			mousePosition.x = mousePosition.x - obj_pos.x;
			mousePosition.y = mousePosition.y - obj_pos.y;
			float angle = Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg;
			rigidbody.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle - 90f));
		}

		//Movement
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0.0f);
		//rigidbody.velocity = movement * thrustSpeed; // for instant position changing
		rigidbody.AddForce(movement * thrustSpeed * Time.deltaTime);
	}
}
