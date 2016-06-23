using UnityEngine;
using System.Collections;

public class PointerRotate : MonoBehaviour
{
	public int speed = 20;

	void Start ()
	{
		//playerLoc = player.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.RotateAround (transform.position, Vector3.up, speed * Time.deltaTime);
	}
}
