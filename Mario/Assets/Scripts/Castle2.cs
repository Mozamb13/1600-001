using UnityEngine;
using System.Collections;

public class Castle2 : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}
	public GameObject other;
	public GameObject other2;
	public GameObject gumba;
	public GameObject gumba1;
	public GameObject gumba2;
	public GameObject gumba3;
	public GameObject gumba4;

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Castle 3") {
			Destroy (GetComponent<SpriteRenderer> ());
			Destroy (GetComponent<BoxCollider2D> ());
			Destroy (GetComponent<CircleCollider2D> ());
			Destroy (other);
			Destroy (other2);
			print ("Mario Loses");
			Destroy (gumba);
			Destroy (gumba1);
			Destroy (gumba2);
			Destroy (gumba3);
			Destroy (gumba4);
		} 

	}
}
