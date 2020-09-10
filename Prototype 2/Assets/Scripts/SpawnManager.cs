﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnablePrefabs;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            int prefabIndex = Random.Range(0, spawnablePrefabs.Length);
            Instantiate(spawnablePrefabs[prefabIndex], new Vector3(0, 0, 20), spawnablePrefabs[0].transform.rotation);
        }
    }
}
