using UnityEngine;
using System.Collections;

public class Enumeration : MonoBehaviour {

	enum Direction{Up, Right, Down, Left};

	void Start()
	{
		Direction myDirection;

		myDirection = Direction.Up;
	}
	Direction ReverseDirection (Direction dir)
	{
		if (dir == Direction.Up)
			dir = Direction.Down;
		if (dir == Direction.Down)
			dir = Direction.Up;
		if (dir == Direction.Right)
			dir = Direction.Left;
		if (dir == Direction.Left)
			dir = Direction.Right;

		return dir;
	}
}

