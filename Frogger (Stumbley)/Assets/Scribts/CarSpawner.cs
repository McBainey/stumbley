using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour {

	public float spawnDelay = .3f;

	public GameObject car;

	public Transform[] spawnPoints;

	float nextTimeToSpawn = 0f;

	GameObject ThePrefabClone; 

	void Update ()
	{
		if (nextTimeToSpawn <= Time.time)
		{
			SpawnCar();
			nextTimeToSpawn = Time.time + spawnDelay;
		}
	}

	void SpawnCar ()
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);
		Transform spawnPoint = spawnPoints[randomIndex];

		ThePrefabClone = Instantiate(car, spawnPoint.position, spawnPoint.rotation) as GameObject;
		Destroy(ThePrefabClone ,7.0f); //spawns last for 7 seconds
	}

}
