using Elementary;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mechanic
{
    public sealed class TakeDemageMechanic : MonoBehaviour
    {
        [SerializeField]
        private EventReceiver_Int takeDamageReciver;

        [SerializeField]
        private IntBehaviour hitPoints;

        private void OnEnable()
        {
            takeDamageReciver.OnEvent += TakeDamage;
        } 

        private void OnDisable()
        {
            takeDamageReciver.OnEvent += TakeDamage;
        }

        [Button]
        private void TakeDamage(int damage)
        {
            hitPoints.Minus(damage); 
        }

    }
}

