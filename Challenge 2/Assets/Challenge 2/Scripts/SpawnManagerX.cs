/* Broc Edson
 * Challenge 2
 * Spawns random balls at random times in random places
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    public float minInterval = 3f;
    public float maxInterval = 5f;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;
    private bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnBallsAtRandomIntervals());
    }

    IEnumerator SpawnBallsAtRandomIntervals()
    {
        yield return new WaitForSeconds(startDelay);

        while(!gameOver)
        {
            SpawnRandomBall();

            spawnInterval = Random.Range(minInterval, maxInterval);

            yield return new WaitForSeconds(spawnInterval);
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int randomIndex = Random.Range(0, 3);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomIndex], spawnPos, ballPrefabs[randomIndex].transform.rotation);
    }

}
