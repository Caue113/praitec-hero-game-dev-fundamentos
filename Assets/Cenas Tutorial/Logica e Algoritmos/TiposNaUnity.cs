using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aula
{
    public class TiposNaUnity : MonoBehaviour
    {
        //Numeros
        public int integer;             //Inteiro
        public uint inteiroPositivo;    //Inteiro positivo
        public long inteiroLongo;       //Inteiro longo

        public float flo;               //Numero Decimal
        public decimal dem;             //Numero Decimal mais preciso

        //Booleano
        public bool boool;              //Booleano (verdadeiro ou falso)

        //Texto
        public char chr;
        public string str;

        //Enumerações
        public EnumeracaoDeComida minhaComidaFavorita;


        /* Estruturas lineares */

        //Listas 
        public List<int> meusNumeros;

        //Arrays
        public float[] meusNumerosDecimais;

        /* === Especifico da Unity === */

        //GameObject da Unity
        public GameObject umObjeto;

        //Vetores para matemática
        public Vector2 vec2;
        public Vector3 vec3;

        //Cores
        public Color color;

        //ScriptableObject da Unity
        public ScriptableObject umScriptableObject;
    }


    public enum EnumeracaoDeComida
    {
        Arroz,
        Feijao,
        Batata
    }

}
