using UnityEngine;
using System.Collections;

public class HandMeasurer : MonoBehaviour {

	public GameObject handBase;
	public float octaveSpan = 30f;
	public int octaveDivisions = 6;

	private float lowY = 0f;

	private float HandHeight()
	{
		return Mathf.Abs (lowY - handBase.transform.position.y);
	}

	public int CurrentDivision()
	{
		if (Input.GetKey (KeyCode.Q))
			return 0;
		if (Input.GetKey (KeyCode.W))
			return 1;
		if (Input.GetKey (KeyCode.E))
			return 2;
		if (Input.GetKey (KeyCode.R))
			return 3;
		if (Input.GetKey (KeyCode.T))
			return 4;
		if (Input.GetKey (KeyCode.Y))
			return 5;
		if (Input.GetKey (KeyCode.U))
			return 6;
		if (Input.GetKey (KeyCode.I))
			return 7;




		float noteSpace = octaveSpan / (float)octaveDivisions;
		int currentDivision = Mathf.FloorToInt (HandHeight() / noteSpace);
		//Debug.Log (currentDivision);
		return currentDivision;
	}
	
	void Update () 
	{
		if (lowY == 0 && handBase.transform.position.y != 0)
			lowY = handBase.transform.position.y;

		//Debug.Log (CurrentDivision());
	}
}
