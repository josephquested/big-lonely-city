using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	Transform moon;

	public float health;

	void Start ()
	{
		moon = GameObject.FindWithTag("Moon").transform;
	}

	void Update ()
	{
		RaycastHit hitInfo;

		if (Physics.Linecast(transform.position, moon.position, out hitInfo))
		{
			if (hitInfo.collider.tag == "Moon")
			{
				print("in moon!");
				health -= 0.1f;
			}
		}

		if (health <= 0)
		{
			print("dead!");
		}
	}
}
