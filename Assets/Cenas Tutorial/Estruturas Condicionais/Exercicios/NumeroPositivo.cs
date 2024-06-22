using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Exercício: Faça um código para verificar se um número é positivo e mostre na tela se ele for positivo;
 */

namespace Aula_Estruturas_Condicinais
{
    public class NumeroPositivo : MonoBehaviour
    {
        public int numero;

        void Start()
        {
            Debug.Log("Exercício 1 - Número é positivo?");

            if (numero > 0)
            {
                Debug.Log("O número é positivo");
            }
        }
    }
}
