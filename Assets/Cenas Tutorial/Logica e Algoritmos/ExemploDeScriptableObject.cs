using UnityEngine;

namespace Aula
{

    [CreateAssetMenu(fileName = "Personagem", menuName = "ScriptableObjects/PersonagemScritableObject", order = 1)]
    public class ExemploDeScriptableObject : ScriptableObject
    {
        public string Nome;
        public short Vidas;
        public EnumeracaoDeComida ComidaFavorita;

        public string[] Equipamentos;
    }
}

