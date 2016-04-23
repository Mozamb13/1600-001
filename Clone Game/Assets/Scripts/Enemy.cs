using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public float movespeed;
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (movespeed, 0, 0) *Time.deltaTime);

		if(GetComponent<Rigidbody2D> ().velocity.x > 0) {
			animator.SetBool ("Gumba walk",true );
		}
	}
}