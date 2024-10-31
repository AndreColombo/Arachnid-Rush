using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorChuva : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar = 8;
    private float cronometro;
    [SerializeField]
    private GameObject modeloChuva;

    private void Awake()
    {
        cronometro = tempoParaGerar;
    }

    void Update()
    {
        cronometro -= Time.deltaTime;
        if (cronometro < 0)
        {
            GameObject.Instantiate(modeloChuva, transform.position, Quaternion.identity);
            cronometro = tempoParaGerar;
        }
    }
}