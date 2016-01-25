using UnityEngine;
using System.Collections;

public class conventionsandsyntax : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		//The following line of code is used to track the position on the falling cube. Debug.log();
	}
	// Update is called once per frame
	void Update () 
	{
		
		Debug.Log (transform.position.y);

		if (transform.position.y <= 5f) 
		{
			Debug.Log ("I'm going to splatter!");
		}

	}
}
