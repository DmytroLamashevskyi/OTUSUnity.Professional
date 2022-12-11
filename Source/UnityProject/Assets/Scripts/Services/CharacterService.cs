using Assets.Scripts.Components;
using Entities;
using UnityEngine;

namespace Assets.Scripts.Services
{
    public class CharacterService :MonoBehaviour
    {
        [SerializeField]
        private UnityEntity character;

        public IEntity GetCharacter()
        {
            return character;
        }
    }
}
