using UnityEngine;
using System.Collections;

public class Anotherclass : MonoBehaviour {

	public int agumon;
	public int gabumon;

	private int pikachu;
	private int charmander;

	public void Digivice(int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log ("Digimon total:" + answer);
	}
	private void Pokedex(int a, int b)
	{
		int answer;
		answer = a+b;
		Debug.Log ("Pokemon total:" +answer);
	}
}
