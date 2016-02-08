using UnityEngine;
using System.Collections;

public class ForeachLoop : MonoBehaviour 
{
	void Start () 
	{
		string[] strings = new string[5];

		strings [0] = "Battle Droid";
		strings [1] = "Clone Troopers";
		strings [2] = "Jedi";
		strings [3] = "Sith";
		strings [4] = "Arc Troopers";

		foreach (string item in strings) {
			print (item);
		}
	}

}
