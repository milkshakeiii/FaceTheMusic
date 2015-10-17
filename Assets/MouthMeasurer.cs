using UnityEngine;
using System.Collections;

public class MouthMeasurer : MonoBehaviour 
{
	public GameObject mouthTop;
	public GameObject mouthBottom;
	public GameObject mouthLeft;
	public GameObject mouthRight;
	public GameObject nose;

	private float neutralAaa = 0f;
	private float neutralEee = 0f;
	private float neutralOoo = 0f;

	public float AaaDistance()
	{
		return Mathf.Abs (Vector3.Distance (mouthTop.transform.position, mouthBottom.transform.position));
	}

	public float EeeDistance()
	{
		return Mathf.Abs (Vector3.Distance (mouthLeft.transform.position, mouthRight.transform.position));
	}

	public float OooDistance()
	{
		return Mathf.Abs (nose.transform.position.z - mouthTop.transform.position.z);
	}

	public float NeutralAaa()
	{
		return neutralAaa;
	}
	
	public float NeutralEee()
	{
		return neutralEee;
	}
	
	public float NeutralOoo()
	{
		return neutralOoo;
	}

	public float AaaStrength()
	{
		float aaaStrength = 10 * (AaaDistance () - NeutralAaa ());
		if (aaaStrength < 0)
			return 0;
		else return aaaStrength * aaaStrength;
	}
	public float EeeStrength()
	{
		float eeeStrength = 10 * (EeeDistance () - NeutralEee ());
		if (eeeStrength < 0)
			return 0;
		else return eeeStrength * eeeStrength;
	}
	public float OooStrength()
	{
		float oooStrength = 15 * (OooDistance() - NeutralOoo());
        Debug.Log(oooStrength);
		if (oooStrength < 0)
			return 0;
		else return oooStrength * oooStrength;
	}

	// Update is called once per frame
	void Update () 
	{
		//Debug.Log (AaaDistance ());
		//Debug.Log (EeeDistance ());
		//Debug.Log (OooDistance ());
	
		if (neutralAaa == 0f && AaaDistance () != 0f) {
			neutralAaa = AaaDistance ();
			Debug.LogWarning ("Set neutral: " + neutralAaa);
		}
		if (neutralEee == 0f && EeeDistance () != 0f) {
			neutralEee = EeeDistance ();
			Debug.LogWarning ("Set neutral: " + neutralEee);
		}
		if (neutralOoo == 0f && OooDistance () != 0f) {
			neutralOoo = OooDistance ();
			Debug.LogWarning ("Set neutral: " + neutralOoo);
		}
	}
}