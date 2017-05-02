using UnityEngine;
using System.Collections;

public class Headstomp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnCollisionEnter2D(Collision2D col)
	{

		if (col.gameObject.tag == "Gumba") 
		{
			Destroy (col.gameObject);
		}
		if (col.gameObject.tag == "Goomba") 
		{
			Destroy (col.gameObject);

		}
	
	}
}
