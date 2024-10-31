using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chuva : MonoBehaviour
{
    private float variacaoDaPosicaoX = 3f;
    private LivesManager livesManager;

    void Awake()
    {
        transform.Translate(Vector3.right * Random.Range(variacaoDaPosicaoX, -variacaoDaPosicaoX));
    }
}