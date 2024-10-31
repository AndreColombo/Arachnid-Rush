using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Predio : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 1.75f;

    private Vector3 posicaoInicial;
    private float tamanhoReal;

    private void Awake()
    {
        posicaoInicial = transform.position;
        float tamanhoDaImagem = GetComponent<SpriteRenderer>().size.y;
        float escala = transform.localScale.y;
        tamanhoReal = tamanhoDaImagem * escala;
    }


    void Update()
    {
        float deslocamento = Mathf.Repeat(velocidade * Time.time, tamanhoReal);
        transform.position = posicaoInicial + Vector3.down * deslocamento;
    }
}
