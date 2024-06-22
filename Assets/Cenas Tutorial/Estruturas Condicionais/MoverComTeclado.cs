using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aula_Estruturas_Condicinais
{
    public class MoverComTeclado : MonoBehaviour
    {
        public float velocidadeX = 2f, velocidadeY = 2f;

        void Start(){}

        void Update()
        {
            if(Input.GetKey(KeyCode.LeftArrow))
            {
                Debug.Log("Andando para Esquerda");
                transform.position += Vector3.left * velocidadeX * Time.deltaTime;
            }

            if(Input.GetKey(KeyCode.RightArrow))
            {
                Debug.Log("Andando para Direita");
                transform.position += Vector3.right * velocidadeX;
            }

            if(Input.GetKey(KeyCode.UpArrow))
            {
                Debug.Log("Andando para Cima");
                transform.position += Vector3.up * velocidadeY;
            }

            if(Input.GetKey(KeyCode.DownArrow))
            {
                Debug.Log("Andando para Baixo");
                transform.position += Vector3.down * velocidadeY;
            }

        }
    }
}
