using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorPassaro : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerar = 25;
    private float cronometro;
    [SerializeField]
    private GameObject modeloPassaro;

    private void Awake()
    {
        cronometro = tempoParaGerar;
    }

    void Update()
    {
        cronometro -= Time.deltaTime;
        if (cronometro < 0)
        {
            GameObject.Instantiate(modeloPassaro, transform.position, Quaternion.identity);
            cronometro = tempoParaGerar;
        }
    }
}