using UnityEngine;
using System.Collections;

public class ifStatements : MonoBehaviour {

	public float cubeTemperature = 100.0f;
	public float hotLimitTemperature = 90.0f;
	public float roomLimitTemperature = 80.0f;
	public float coldLimitTemperature = 40.0f;
	
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space))
			TemperatureTest ();

		cubeTemperature -= Time.deltaTime * 5f;
	
	}

	void TemperatureTest ()
	{
		if (cubeTemperature > hotLimitTemperature) {
			print ("Holy Moly! I'm too hot!!");
		}
		if (cubeTemperature < coldLimitTemperature) {
			print ("Holy Moly! I'm too cold!!.");
		}
		if (cubeTemperature < roomLimitTemperature  )
		{
			print ("Aww that feels right.");
		}
	}

}
