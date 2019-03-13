using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muro : MonoBehaviour
{
    private bool abierto;
    private void Update()
    {
        if (abierto)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 20);
        }
    }
    private void Awake()
    {
        abierto = false;
    }
    public void Abrir()
    {
        abierto = true;
    }
}
