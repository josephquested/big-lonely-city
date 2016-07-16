using UnityEngine;
using System.Collections;

public class Glimpse : MonoBehaviour {
	Transform moon;
	NavMeshAgent agent;
	Transform goal;

	bool firstUpdate = true;

	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
		goal = GameObject.FindWithTag("Player").transform;
		moon = GameObject.FindWithTag("Moon").transform;
	}

	void Update ()
	{
		RaycastHit hitInfo;

		if (Physics.Linecast(transform.position, moon.position, out hitInfo))
		{
			if (hitInfo.collider.tag == "Moon")
			{
				Destroy(gameObject);
				return;
			}
		}

		if (agent != null)
		{
			UpdateAgent();
		}
	}

	void UpdateAgent ()
	{
		if (goal != null && !firstUpdate)
		{
			agent.destination = goal.position;
		}

		firstUpdate = false;
	}
}
