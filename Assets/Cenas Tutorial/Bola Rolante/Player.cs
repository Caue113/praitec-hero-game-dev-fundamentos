using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AulaProjetoBola
{
    public class Player : MonoBehaviour
    { 
        //Eixo X
        public float velocidadeFrontal;
        public float velocidadeMaximaFrontal = 8f;

        //Eixo Z, controlado pelo teclado
        public float forcaHorizontal = 5f;
        public float velocidadeMaximaHorizontal = 10f;

        //Pulo do personagem
        public bool podePular = true;
        public float forcaPulo = 10f;

        Rigidbody rb;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            Vector3 velocidade = rb.velocity;

            float inputHorizontal = -Input.GetAxisRaw("Horizontal");


            //Add forca para frente progressivo (X) somente se não passar do limite
            if(velocidade.x < velocidadeMaximaFrontal)
            {
                rb.AddForce(velocidadeFrontal, 0, 0, ForceMode.Acceleration);
            }

            //Add forca lateral
            rb.AddForce(0, 0, inputHorizontal * forcaHorizontal * Time.deltaTime, ForceMode.Acceleration);
            
            //Add pulo
            if(podePular && Input.GetKey(KeyCode.Space))
            {
                podePular = false;
                rb.AddForce(0, forcaPulo, 0, ForceMode.Impulse);
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            Collider outroColisor = collision.collider;

            if(outroColisor.tag == "chao")
            {
                podePular = true;
            }
            else if(outroColisor.CompareTag("inimigo"))
            {
                Debug.Log("Você machucou :(");
            }
        }
    }
}