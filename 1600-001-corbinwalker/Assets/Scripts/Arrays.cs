using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour 
{
	public GameObject[] Troopers;

	// Use this for initialization
	void Start () 
	{
		Troopers = GameObject.FindGameObjectsWithTag ("Player");

		for (int i = 0; i < Troopers.Length; i++) {
			Debug.Log ("Trooper " + i + " is named" + Troopers [i].name);
		}
	}
}
