using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int valor = 100;
    string texto;

    void Start()
    {
        texto = valor.ToString ();

        print (texto); // O resultado será 100, só que em string
    }

    void Update()
    {
        
    }
}