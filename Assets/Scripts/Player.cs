using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	Transform moon;
	public bool inLight;


	public float health;

	void Start ()
	{
		moon = GameObject.FindWithTag("Moon").transform;
	}

	void Update ()
	{
		UpdateLightStatus();
		
		if (health <= 0)
		{
			// dead
		}
	}

	void UpdateLightStatus ()
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
}
