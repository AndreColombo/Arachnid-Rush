using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horizontal : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 2.5f;
    private float variacaoDaPosicaoY = 3.5f;
    void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(variacaoDaPosicaoY, -variacaoDaPosicaoY));
    }


    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector2.left);
    }
}