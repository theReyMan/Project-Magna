using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
	public int speed = 10;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void FixedUpdate ()
	{
		if (Input.GetKey ("up")) {
			this.GetComponent<Rigidbody> ().AddForce (Vector3.forward * speed);
		}
			
		if (Input.GetKey ("right")) {
			this.GetComponent<Rigidbody> ().AddForce (Vector3.right * speed);

		}
			
		if (Input.GetKey ("down")) {
			this.GetComponent<Rigidbody> ().AddForce (Vector3.back * speed);
		}
			
		if (Input.GetKey ("left")) {
			this.GetComponent<Rigidbody> ().AddForce (Vector3.left * speed);
		}
			

	}

}