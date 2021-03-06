using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour
{

	public float spawnDelay = .3f;

	public GameObject IncommingObject;

	//public GameObject ParticleEffect;

	public Transform[] spawnPoints;

	float nextTimeToSpawn = 0f;

	GameObject ThePrefabClone;

	void Update()
	{
		if (nextTimeToSpawn <= Time.time)
		{
			SpawnCar();
			nextTimeToSpawn = Time.time + spawnDelay;
		}
	}

	void SpawnCar()
	{
		int randomIndex = Random.Range(0, spawnPoints.Length);
		Transform spawnPoint = spawnPoints[randomIndex];

		ThePrefabClone = Instantiate(IncommingObject, spawnPoint.position, spawnPoint.rotation) as GameObject;
		Destroy(ThePrefabClone, 7.0f); //spawns last for 7 seconds
	}

void OnTriggerEnter2d (Collider2D other)
{
	if (other.gameObject.tag == "PassingObject")
	{
	ThePrefabClone = Instantiate(IncommingObject, transform.position, transform.rotation) as GameObject;
    Destroy(ThePrefabClone);
	}
}
}

//void DestroyAllObjects()
//{
		//IncommingObject = GameObject.FindGameObjectWithTag("PassingObject");

		//foreach (GameObject r in IncommingObject)
	//{
		//Destroy(r.gameObject);
	//}
//}
