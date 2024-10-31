using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Spider : MonoBehaviour
{
    public float moveSpeed = 2;
    public float hInput;
    public float vInput;
    private PointManager pointManager;
    private AudioSource audioSource;
    private LivesManager livesManager;

    void Start()
    {
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
        audioSource = GetComponent<AudioSource>();
        livesManager = FindObjectOfType<LivesManager>();
    }

    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(hInput * moveSpeed * Time.deltaTime * Vector2.right);
        vInput = Input.GetAxisRaw("Vertical");
        transform.Translate(vInput * moveSpeed * Time.deltaTime * Vector2.up);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Moeda")
        {
            Destroy(collision.gameObject);
            pointManager.UpdateScore(1);
            audioSource.Play();
        }

        if (collision.gameObject.tag == "Chuva" || collision.gameObject.tag == "Deletar")
        {
            livesManager.LoseLife();
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
