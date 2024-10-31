using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorJanela : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar = 2.5f;
    private float cronometro;
    [SerializeField]
    private GameObject modeloJanela;

    private void Awake()
    {
        cronometro = tempoParaGerar;
    }

    void Update()
    {
        cronometro -= Time.deltaTime;
        if (cronometro < 0)
        {
            GameObject.Instantiate(modeloJanela, transform.position, Quaternion.identity);
            cronometro = tempoParaGerar;
        }
    }
}