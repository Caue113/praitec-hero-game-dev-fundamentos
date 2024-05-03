using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aula
{
    public class AlgoritmoConsole1 : MonoBehaviour
    {
        void Start()
        {
            Debug.Log("Olá");

            Debug.Log("Meu nome é Luís");


            Debug.LogWarning("Eu sou um AVISO!");
            Debug.LogError("Eu sou um erro!");
        }
    }
}