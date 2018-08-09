using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerController : MonoBehaviour {

	private Rigidbody rb;

	public float speed;

	void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	void Update ()
	{

	}

	void FixedUpdate()
	{
		var movementHorizontal = Input.GetAxis("Horizontal");
		var movementVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(movementHorizontal, 0.0f, movementVertical);
		rb.AddForce(movement * speed);
	}
	
}
