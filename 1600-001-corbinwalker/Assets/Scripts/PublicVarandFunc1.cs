using UnityEngine;
using System.Collections;

public class PublicVarandFunc1 : MonoBehaviour 
{
	public int  myInt = 2000;
		
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		myInt = MultiplyByTwo(myInt);
		Debug.Log (myInt); 
	}

		int MultiplyByTwo (int number)
	{
		int ret;
		ret = number * 2;
		return ret;
	}
}
