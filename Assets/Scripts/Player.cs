using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	Transform moon;
	public bool inLight;
	public float sanity;
	public float sanityDrain;

	void Start ()
	{
		moon = GameObject.FindWithTag("Moon").transform;
	}

	void Update ()
	{
		DetectLight();
		UpdateSanity();
	}

	void DetectLight ()
	{
		RaycastHit hitInfo;

		if (Physics.Linecast(transform.position, moon.position, out hitInfo))
		{
			if (hitInfo.collider.tag == "Moon")
			{
				inLight = true;
			}
			else
			{
				inLight = false;
			}
		}
	}

	void UpdateSanity ()
	{
		if (inLight)
		{
			sanity -= sanityDrain;
		}
	}
}
