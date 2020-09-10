/* Broc Edson
 * Prototype 2
 * Destroys an object when it is out of bounds
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;

    private HealthSystem healthSystemScript;

    private void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound || transform.position.z < bottomBound)
        {
            Destroy(gameObject);
            if(transform.position.z < bottomBound)
            {
                healthSystemScript.TakeDamage();
                Debug.Log("Game Over!");
            }
        }
    }
}
