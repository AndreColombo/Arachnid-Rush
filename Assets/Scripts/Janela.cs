using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Janela : MonoBehaviour
{
    private LivesManager livesManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Moeda" || collision.gameObject.tag == "Chuva")
        {
            Destroy(collision.gameObject);
        };
        if (collision.gameObject.tag == "Deletar")
        {
            Destroy(gameObject);
        };
    }
}