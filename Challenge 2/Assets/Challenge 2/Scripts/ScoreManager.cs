/* Broc Edson
 * Prototype 2
 * Manages the score
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public Text endText;
    public Text scoreText;

    private HealthSystem healthSystem;

    // Start is called before the first frame update
    void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        if(score >= 5)
        {
            endText.text = "You Win!\nPress R to Restart";
            healthSystem.gameOver = true;
        }
    }
}
