using UnityEngine;
using System.Collections;

public class SwitchStatement : MonoBehaviour {

	public int intelligence = 6;

	void Greet()
	{
		switch (intelligence) 
		{
		case 6:
			print ("Hello there good sir how are you this morning?");
			break;
		case 5:
			print ("Did you finish you report for Johnson?");
			break;
		case 4:
			print ("Hey make sure to pay your college fund if not do you really want to spen your night in jail?");
			break;
		case 3:
			print ("When did your computer become your cheap movie theater?");
			break;
		case 2:
			print ("Im a high functioning computer not a gameboy?");
			break;
		case 1:
			print ("Do you even know how to use a computer?");
			break;
		default:
			print ("Not enough knowledge to use this unit");
			break;
		}
	}

}
