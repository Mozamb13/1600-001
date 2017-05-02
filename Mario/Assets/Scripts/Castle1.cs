using UnityEngine;
using System.Collections;

public class Castle1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public GameObject other;

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Castle 2") 
		{
			Destroy(col.gameObject);
			Destroy (GetComponent<SpriteRenderer>());
			Destroy (GetComponent<BoxCollider2D>());
			Destroy (GetComponent<CircleCollider2D>());
			Destroy (other);
		}
	}
}