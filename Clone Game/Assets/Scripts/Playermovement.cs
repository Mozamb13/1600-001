using UnityEngine;
using System.Collections;

public class Playermovement : MonoBehaviour {
	public float speed = 1f;
	private float jumpheight = 750f;
	public bool isJumping = false;

	private Animator animator;


	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			transform.position += new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
			animator.SetTrigger ("Mario Run");
		}
		
		if (Input.GetKey (KeyCode.A)) {
			transform.position -= new Vector3 (speed * Time.deltaTime, 0.0f, 0.0f);
			animator.SetTrigger ("Mario Run");

		}

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			if (isJumping == false) {
				GetComponent<Rigidbody2D> ().AddForce (Vector2.up * jumpheight);
				isJumping = true;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Ground") 
		{
			animator.SetTrigger ("Mario Land");
			isJumping = false;
		}
		if (col.gameObject.tag == "Gumba") 
		{
			animator.SetTrigger ("Mario Land");
			Destroy(col.gameObject);
			isJumping = false;
		}
		if (col.gameObject.tag == "Goomba") 
		{
			animator.SetTrigger ("Mario Wins");
			Destroy(col.gameObject);
			isJumping = false;
			print ("Mario Wins");
		}
	}
	
}