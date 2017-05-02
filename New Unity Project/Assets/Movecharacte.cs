using UnityEngine;
using System.Collections;

public class Movecharacte : MonoBehaviour {

	private CharacterController mycc;
	//temp var of datatype vector 3 to move the character
	private Vector3 tempPos;
	public float speed = 1;
	public float gravity = -5;
	public float jumpspeed = 1;

	void Start () {
		mycc = GetComponent<CharacterController> ();
	}
	
	// Update is called nce per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			tempPos.y = jumpspeed;
		}
		tempPos.y -= gravity;
		tempPos.x = speed * Input.GetAxis ("Horizontal");
		mycc.Move(tempPos * Time.deltaTime);
	}
}
