using UnityEngine;
using System.Collections;

public class Castle4 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Gumba") 
		{
			Destroy (GetComponent<SpriteRenderer>());
			Destroy (GetComponent<BoxCollider2D>());
	
		}
		if (col.gameObject.tag == "Goomba") 
		{
			Destroy (GetComponent<SpriteRenderer>());
			Destroy (GetComponent<BoxCollider2D>());

		}
	}
}
