using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public GameObject playerPrefab;
	public GameObject enemyPrefab;
	public int NumberOfBots;
	
    // Start is called before the first frame update
    void Start()
    {
		var spawnPoints= GameObject.FindGameObjectsWithTag("SpawnPoint").ToList();

		//Spawning Player 
		int r = Random.Range(0, spawnPoints.Count);
		GameObject.Instantiate<GameObject>(playerPrefab, spawnPoints[r].transform);
		spawnPoints.RemoveAt(r);

		//Spawning Enemy Bots
		for (int i=0; i<NumberOfBots; ++i)
		{
			r = Random.Range(0, spawnPoints.Count);
			GameObject.Instantiate<GameObject>(enemyPrefab, spawnPoints[r].transform);
			spawnPoints.RemoveAt(r);
		}

    }

  
}
