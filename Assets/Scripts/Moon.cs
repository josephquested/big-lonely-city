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
			player = GameObject.FindWithTag("Player").GetComponent<Player>();
		}
	}

	void UpdateVolume ()
	{
		if (player.inLight)
		{
			audioSource.volume = 1f;
		}
		else
		{
			audioSource.volume = 0.2f;
		}
	}
}
