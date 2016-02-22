using UnityEngine;
using System.Collections;

public class ScopeandAccessmodifer : MonoBehaviour 
{
	public int alpha = 8;

	private int beta = 0;
	private int gamma = 8; 

	private Anotherclass myOtherclass;

	void Start ()
	{
		alpha = 30;
		myOtherclass = new Anotherclass ();
		myOtherclass.Digivice (alpha, myOtherclass.agumon); 
	}

	void Example (int digimon, int pokemon) 
	{
		int answer;
		answer = digimon * pokemon * alpha;
		Debug.Log (answer);
	
	}

	void Update () 
	{
		Debug.Log ("Alpha is set to: " + alpha);
	}
}
