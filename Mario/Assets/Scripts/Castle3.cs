using UnityEngine;
using System.Collections;

public class Castle3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Castle") 
		{
			Destroy (GetComponent<SpriteRenderer>());
			Destroy (GetComponent<BoxCollider2D>());
			print ("Mario Wins");
				}
				if (col.gameObject.tag == "Castle 2") 
				{
					Destroy (GetComponent<SpriteRenderer>());
					Destroy (GetComponent<BoxCollider2D>());
					print ("Mario Wins");

						}
						}
}
