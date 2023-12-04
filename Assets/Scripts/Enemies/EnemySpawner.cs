using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float spawnRate = 1f;
    [SerializeField] private GameObject[] enemyPrefabs;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private bool canSpawn = true;


    private void Start(){
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner(){
        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while(canSpawn){
            yield return wait;

            int enemyRnd = Random.Range(0, enemyPrefabs.Length);
            GameObject enemyToSpawn = enemyPrefabs[enemyRnd];
            int spwnRnd = Random.Range(0, spawnPoints.Length);
            Transform randomSpawnPoint = spawnPoints[spwnRnd];
            Instantiate(enemyToSpawn, randomSpawnPoint.position, Quaternion.identity);
        }
    }

}
