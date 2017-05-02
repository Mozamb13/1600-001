using UnityEngine;
using System.Collections;

public class Moveplayerscript : MonoBehaviour {

	public float speed = 10;
	//use to move the player
	private CharacterController controller;
	public float gravity = -9.81f;
	// use to assign location as a temp var
	private Vector3 tempPosistion;

	void Start () {
	
		controller = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		tempPosistion.y = gravity;
		//using axis with input as speed the character can hold or move left or right
		tempPosistion.x = speed*Input.GetAxis("Horizontal");
		tempPosistion *= Time.deltaTime;
		//move method takes the temp vector3 to move
		controller.Move(tempPosistion);
	}
}
