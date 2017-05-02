using UnityEngine;
using System.Collections;

public class Restartbutton : MonoBehaviour {

	public void Restart_Game_button () {
		Application.LoadLevel("Main game");
	}

}