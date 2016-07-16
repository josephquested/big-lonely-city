using UnityEngine;
using System.Collections;

public class GlimpseSpawner : MonoBehaviour
{
	public GameObject glimpsePrefab;
	public float mapSize;
	public float spawnRate;

	bool canSpawn = true;

  void Update ()
	{
		if (canSpawn)
		{
			StartCoroutine(SpawnCoroutine());
		}
  }

	IEnumerator SpawnCoroutine ()
	{
		canSpawn = false;
		yield return new WaitForSeconds(spawnRate);
		SpawnGlimpse();
		canSpawn = true;
	}

	void SpawnGlimpse ()
	{
	 	Vector3 position = new Vector3(
			Random.Range(-mapSize / 2, mapSize / 2),
			0.5f,
			Random.Range(-mapSize / 2, mapSize / 2)
		);

	  var hitColliders = Physics.OverlapSphere(position, 1);
	  if (hitColliders.Length <= 1)
		{
			Instantiate(glimpsePrefab, position, transform.rotation);
		}
	}
}
