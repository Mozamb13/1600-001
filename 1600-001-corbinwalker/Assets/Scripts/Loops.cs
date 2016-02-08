using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour 
{
	int numDroids = 6;


	void Start () 
	{
		for(int i = 0; i < numDroids; i++)
		{
			Debug.Log("Manufacturing Sepratist Droids:" + i);
		}
	}

}