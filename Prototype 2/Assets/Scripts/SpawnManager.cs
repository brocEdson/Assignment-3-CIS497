using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnablePrefabs;

    public float leftBound = -14;
    public float rightBound = 14;
    public float spawnPosZ = 20;

    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);
    }

    void SpawnRandomPrefab()
    {
        int prefabIndex = Random.Range(0, spawnablePrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);
        Instantiate(spawnablePrefabs[prefabIndex], spawnPosition, spawnablePrefabs[0].transform.rotation);
    }
}
