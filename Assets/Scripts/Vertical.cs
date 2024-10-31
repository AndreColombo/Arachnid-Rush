using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertical : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 1.5f;


    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector2.down);
    }
}