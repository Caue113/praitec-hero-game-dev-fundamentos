using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aula
{
    public class CalculadoraSimples : MonoBehaviour
    {

        public int numero1;
        public int numero2;

        public float numeroDecimal1;
        public float numeroDecimal2;

        public decimal numeroDecimalMaior1;
        public decimal numeroDecimalMaior2;

        void Start()
        {
            Debug.Log("Vou fazer uma soma: ");
            Debug.Log(numero1 + numero2);


            Debug.Log("Vou fazer uma subtração: ");
            Debug.Log(numeroDecimal1 - numeroDecimal2);



            numeroDecimalMaior1 = 10;
            numeroDecimalMaior2 = 2;

            Debug.Log("Vou fazer uma multiplicação: ");
            Debug.Log(numeroDecimalMaior1 * numeroDecimalMaior2);
        }
    }

}
