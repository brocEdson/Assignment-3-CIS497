/* Broc Edson
 * Prototype 2
 * Spawns random prefabs in random places at random times
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnablePrefabs;

    public HealthSystem healthSystem;

    public float leftBound = -14;
    public float rightBound = 14;
    public float spawnPosZ = 20;

    // Update is called once per frame
    void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        StartCoroutine(SpawnRandomPrefabWithCoroutine());
    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        yield return new WaitForSeconds(3f);

        while(!healthSystem.gameOver)
        {
            SpawnRandomPrefab();

            float randomDelay = Random.Range(1.5f, 3.0f);
            yield return new WaitForSeconds(randomDelay);
        }
    }

    void SpawnRandomPrefab()
    {
        int prefabIndex = Random.Range(0, spawnablePrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);
        Instantiate(spawnablePrefabs[prefabIndex], spawnPosition, spawnablePrefabs[0].transform.rotation);
    }
}
