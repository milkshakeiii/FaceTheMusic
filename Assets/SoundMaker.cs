using UnityEngine;
using System.Collections;

public class SoundMaker : MonoBehaviour 
{
	public MouthMeasurer mouthMeasurer;

	public float openAaaMin;
	public float openEeeMin;
	public float openOooMin;

	public AudioSource aaa;
	public AudioSource eee;
	public AudioSource ooo;

	void Start () 
	{
	
	}

	void Update ()
	{
		if (mouthMeasurer.AaaDistance () == 0)
			return;

		float aaaStrength = mouthMeasurer.AaaStrength ();
		float eeeStrength = mouthMeasurer.EeeStrength ();
		float oooStrength = mouthMeasurer.OooStrength ();

		Debug.Log ("sAaa: " + aaaStrength);
		Debug.Log ("sEee: " + eeeStrength);
		Debug.Log ("sOoo: " + oooStrength);

		float totalStrength = aaaStrength + eeeStrength + oooStrength;

		float aaaPortion = aaaStrength / totalStrength;
		float eeePortion = eeeStrength / totalStrength;
		float oooPortion = oooStrength / totalStrength;

		if (aaaStrength > openAaaMin || eeeStrength > openEeeMin || oooStrength > openOooMin)
		{
			if (!aaa.isPlaying) aaa.Play();
			if (!eee.isPlaying) eee.Play();
			if (!ooo.isPlaying) ooo.Play();
		}
		else
		{
			aaa.Stop();
			eee.Stop();
			ooo.Stop();
		}

		//Debug.Log ("%Aaa: " + aaaPortion);
		//Debug.Log ("%Eee: " + eeePortion);
		//ebug.Log ("%Ooo: " + oooPortion);

		aaa.volume = aaaPortion * 0.25f;
		eee.volume = eeePortion * 0.25f;
		ooo.volume = oooPortion * 1f;

	}
}