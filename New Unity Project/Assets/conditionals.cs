using UnityEngine;
using System.Collections;

public class conditionals : MonoBehaviour {

	public bool isDoorunlocked = false;

	// Use this for initialization
	void Start ()
	{
		if (isDoorunlocked) {
			Enter ();
		} else {
			Exit ();
		}
	}

	private void Exit()
	{
		print ("the way is shut - he is coming.");
	}
	private void Enter()
	{
		print ("speak friend and enter.");
	}
}
