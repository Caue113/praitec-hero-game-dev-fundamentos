using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aula
{
    public class AlgoritmoConsole2 : MonoBehaviour
    {
        public bool souBonito;

        public float altura = 1.8f;
        public bool souAlto;


        void Start()
        {
            if (souBonito == true)
            {
                Debug.Log("Eu sou Bonito :)");
            }
            else
            {
                Debug.Log("Eu sou feio :(");
            }


            if (souAlto)
            {
                Debug.Log("Eu sou alto");
            }
            else
            {
                Debug.Log("Eu não sou alto");
            }


            //
            if (altura < 1.4f)
            {
                Debug.Log("Eu sou baixinho");
            }
            else if (altura > 2f)
            {
                Debug.Log("Eu sou altão");
            }
            else
            {
                Debug.Log("Eu tenho uma altura media");
            }
        }
    }
}