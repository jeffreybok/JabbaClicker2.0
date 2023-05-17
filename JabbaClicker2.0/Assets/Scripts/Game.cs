using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Text ui;

    public void Incremement()
    {
        GameManager.jabbaScore += GameManager.scoreMultiplier;
    }

    public void Buy(int num)
    {
        if(num == 1 && GameManager.jabbaScore >= 50)
        {
            GameManager.scoreMultiplier += 1;
            GameManager.jabbaScore -= 50;
        }
        if (num == 2 && GameManager.jabbaScore >= 100)
        {
            GameManager.scoreMultiplier += 5;
            GameManager.jabbaScore -= 100;
        }
        if (num == 3 && GameManager.jabbaScore >= 150)
        {
            GameManager.scoreMultiplier += 25;
            GameManager.jabbaScore -= 150;
        }
        if (num == 4 && GameManager.jabbaScore >= 200)
        {
            GameManager.scoreMultiplier += 100;
            GameManager.jabbaScore -= 200;
        }
        if (num == 5 && GameManager.jabbaScore >= 250)
        {
            GameManager.scoreMultiplier += 250;
            GameManager.jabbaScore -= 250;
        }
    }

    public void Update()
    {
        ui.text = "Score: " + GameManager.jabbaScore;
    }
}
