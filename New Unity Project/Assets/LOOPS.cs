using UnityEngine;
using System.Collections;

public class LOOPS : MonoBehaviour {

	public string[] animals = {"dog","cat","raptor"};
	void Start () {
		for (int i = 0; i < animals.Length; i++) {
			print ("The " + animals [i] + " ate my taco");
		}

	}

}
