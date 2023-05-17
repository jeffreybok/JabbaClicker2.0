using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int jabbaScore;
    public static int scoreMultiplier;

    // Start is called before the first frame update
    void Start()
    {
        scoreMultiplier = 1;
        jabbaScore = 0;
    }

    
}
