using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int jabbaScore;
    public static int scoreMultiplier;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        scoreMultiplier = 1;
        jabbaScore = 0;

        // Start invoking the AddScore method every second
        InvokeRepeating("AddScore", 1f, 1f);
    }

    private void AddScore()
    {
        jabbaScore++; // Increment the jabbaScore
    }

    public void AddPoint(int points)
    {
        score += points;
    }
}