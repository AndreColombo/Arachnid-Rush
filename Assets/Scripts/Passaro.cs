using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passaro : MonoBehaviour
{
    private AudioSource audioSource;
    private LivesManager livesManager;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        livesManager = FindObjectOfType<LivesManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            livesManager.LoseLife();
            Destroy(collision.gameObject);
            audioSource.Play();
            Time.timeScale = 0;
        };
        if (collision.gameObject.tag == "Deletar")
        {
            Destroy(gameObject);
        };
    }
}