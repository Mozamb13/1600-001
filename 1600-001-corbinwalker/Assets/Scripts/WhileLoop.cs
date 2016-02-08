using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour 
{
	int gunshipsIntheair = 10;


	void Start () 
	{
		while(gunshipsIntheair > 0)
		{
			Debug.Log ("Clone gunships incoming!");
			gunshipsIntheair--;
		}
	}

}
