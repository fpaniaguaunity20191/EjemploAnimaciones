using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tigre : MonoBehaviour
{
    public Muro muro;
    
    public void StartOpenMuro()
    {
        muro.Abrir();
    }
}
