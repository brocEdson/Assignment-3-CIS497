/* Broc Edson
 * Prototype 2
 * Detects collisions and adds score when a dog collects a ball
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Dog")
        {
            scoreManager.score++;
        }
        Destroy(gameObject);
    }
}
