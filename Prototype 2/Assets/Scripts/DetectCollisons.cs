/* Broc Edson
 * Prototype 2
 * Destroys two objects when a collision occurs
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisons : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject); 
    }
}
