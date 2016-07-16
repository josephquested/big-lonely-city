using UnityEngine;
using System.Collections;

public class GameGenerator : MonoBehaviour
{
	public GameObject playerPrefab;

	public float mapSize;
	public GameObject floorPrefab;

	public GameObject buildingPrefab;
	public int buildings;
	public float buildingMinWidth;
	public float buildingMaxWidth;
	public float buildingMinHeight;
	public float buildingMaxHeight;


  void Start()
	{
		while (buildings > 0)
		{
			SpawnBuilding();
			buildings--;
		}

		SpawnPlayer();
  }

	void SpawnPlayer ()
	{
		Instantiate(playerPrefab, transform.position, transform.rotation);
	}

	void SpawnBuilding ()
	{
	 	Vector3 position = new Vector3(
			Random.Range(-mapSize / 2, mapSize / 2),
			0,
			Random.Range(-mapSize / 2, mapSize / 2)
		);

	 	Vector3 scale = new Vector3(
			Random.Range(buildingMinWidth, buildingMaxWidth),
			Random.Range(buildingMinHeight, buildingMaxHeight),
			Random.Range(buildingMinWidth, buildingMaxWidth)
		);

		GameObject building = (GameObject)Instantiate(
			buildingPrefab,
			position,
			transform.rotation
		);

		building.transform.localScale = scale;
	}
}
