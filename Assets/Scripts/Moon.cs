using UnityEngine;
using System.Collections;

public class Moon : MonoBehaviour {
	Light lightSource;
	AudioSource audioSource;
	Player player;

	void Start ()
	{
		lightSource = GetComponent<Light>();
		audioSource = GetComponent<AudioSource>();
	}

	void Update ()
	{
		FindPlayer();
		UpdateVolume();
	}

	void FindPlayer ()
	{
		if (GameObject.FindWithTag("Player") != null && player == null)
		{
			print("got the player!");
			player = GameObject.FindWithTag("Player").GetComponent<Player>();
		}
	}

	void UpdateVolume ()
	{
		RaycastHit hitInfo;

		if (Physics.Linecast(transform.position, player.transform.position, out hitInfo))
		{
			if (hitInfo.collider.tag == "Player")
			{
				audioSource.volume = 1f;
			}
			else
			{
				audioSource.volume = 0.5f;
			}
		}
	}
}
