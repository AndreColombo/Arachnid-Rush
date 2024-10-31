using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    private float variacaoDaPosicaoX = 2.5f;

    void Awake()
    {
        transform.Translate(Vector3.right * Random.Range(variacaoDaPosicaoX, -variacaoDaPosicaoX));
    }

}