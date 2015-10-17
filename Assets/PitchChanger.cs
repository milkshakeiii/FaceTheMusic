using UnityEngine;
using System.Collections;

public class PitchChanger : MonoBehaviour 
{
	public AudioSource[] changeUs;
	public float[] pitches;
	public HandMeasurer handMeasurer;

	void Update () 
	{
		foreach(AudioSource pitch in changeUs)
		{
			int currentPitch = handMeasurer.CurrentDivision();
			if (currentPitch >= pitches.Length)
				currentPitch = pitches.Length-1;
			pitch.pitch = pitches[currentPitch];
		}
	}
}
