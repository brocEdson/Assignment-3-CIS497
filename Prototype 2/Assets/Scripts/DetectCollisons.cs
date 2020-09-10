/* Broc Edson
 * Prototype 2
 * Destroys two objects when a collision occurs
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisons : MonoBehaviour
{
    private DisplayScore displayScoreScript;

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        Destroy(other.gameObject);
        Destroy(gameObject); 
    }
}
