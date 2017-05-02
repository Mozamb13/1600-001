using UnityEngine;
using System.Collections;

public class Powerupbase : MonoBehaviour {

	public string firstName;
	public string lastName;
	private string userName;

	void OnMouseup ()
	{
		print ( UserInfo () );
		print (userName + " is your user name.");
	}

	string UserInfo()
	{
		userName = firstName + lastName+1138;
		return firstName + " " + lastName + "are you ready to play?";
	}
}
