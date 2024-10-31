using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deletar : MonoBehaviour
{
    private LivesManager livesManager;

    void Start()
    {
        livesManager = FindObjectOfType<LivesManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Moeda" || collision.gameObject.tag == "Passaro" || collision.gameObject.tag == "Chuva" || collision.gameObject.tag == "Janela")
        {
            Destroy(collision.gameObject);
        };
        if (collision.gameObject.tag == "Player")
        {
            livesManager.LoseLife();
            Destroy(collision.gameObject);
            Time.timeScale = 0;
        };
    }
}