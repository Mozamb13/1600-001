using UnityEngine;
using System.Collections;

public class loops1 : MonoBehaviour {
	public string[] powerUps = {"health","Ammo","magic","sheild"};

	// Use this for initialization
	void Start () {
		foreach (string _powerUps in powerUps) {
			print ("I found " + _powerUps + " power-up on the way to grandmas");
		}
	}
	
}
