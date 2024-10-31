using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    public int currentLives = 1;
    public GameObject gameOverPanel;

    public void LoseLife()
    {
        currentLives -= 1;
        if (currentLives <= 0)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
    }
}
