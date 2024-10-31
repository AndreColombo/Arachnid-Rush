using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorMoeda : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar = 10;
    private float cronometro;
    [SerializeField]
    private GameObject modeloMoeda;

    private void Awake()
    {
        cronometro = tempoParaGerar;
    }

    void Update()
    {
        cronometro -= Time.deltaTime;
        if (cronometro < 0)
        {
            GameObject.Instantiate(modeloMoeda, transform.position, Quaternion.identity);
            cronometro = tempoParaGerar;
        }
    }
}