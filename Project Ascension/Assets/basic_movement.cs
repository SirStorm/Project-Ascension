using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basic_movement : MonoBehaviour {
	public bool jump=true;
	public float speed=5f;
	// Use this for initialization

	public Rigidbody rb;
	void Start () {
		rb = GetComponent <Rigidbody>();
	}

	void Update () {
		if (Input.GetKey ("q")) {
			transform.Rotate(-Vector3.up*5);
		}
		if (Input.GetKey ("e")) {
			transform.Rotate(Vector3.up*5);
		}
		if (Input.GetKey ("w")) {
			rb.AddForce(transform.forward*speed*5);
		}
		if (Input.GetKey ("a")) {
			rb.AddForce(-transform.right*speed*5);
		}
		if (Input.GetKey ("s")) {
			rb.AddForce(-transform.forward*speed*5);
		}
		if (Input.GetKey ("d")) {
			rb.AddForce(transform.right*speed*5);
		}
		jumping ();
	}

	void jumping(){
			if (Input.GetKeyDown ("space") && jump==true) {
			rb.AddForce(Vector3.up*speed*100);
			jump = false;
		}

	}

	void OnCollisionEnter(Collision collision)
	{
		jump = true;
	}
}
