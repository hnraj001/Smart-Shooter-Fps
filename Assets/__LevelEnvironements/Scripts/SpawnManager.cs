using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
		GameObject[] spawnPoints= GameObject.FindGameObjectsWithTag("SpawnPoint");
		int r = Random.Range(0, spawnPoints.Length);

		GameObject.Instantiate<GameObject>(enemyPrefab, spawnPoints[r].transform);
        
    }

  
}
