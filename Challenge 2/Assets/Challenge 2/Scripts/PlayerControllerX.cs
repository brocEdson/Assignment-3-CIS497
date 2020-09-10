/* Broc Edson
 * Prototype 2
 * Allows the player to spawn dogs at a reasonable rate
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float delayTime = 0.5f;

    private bool pressed = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !pressed)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            StartCoroutine(PressDelay());
        }
    }

    IEnumerator PressDelay()
    {
        pressed = true;
        yield return new WaitForSeconds(delayTime);
        pressed = false;
    }

}
