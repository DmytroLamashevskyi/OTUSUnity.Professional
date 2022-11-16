using Elementary;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

namespace Mechanic
{
    public sealed class DeathMechanic : MonoBehaviour
    {
        [SerializeField]
        private EventReceiver deathReciver;

        [SerializeField]
        private IntBehaviour hitPoints;

        private void OnEnable()
        {
            hitPoints.OnValueChanged += OnHitPointChanged;
        }

        private void OnDisable()
        {
            hitPoints.OnValueChanged -= OnHitPointChanged;
        }
         
        private void OnHitPointChanged(int newHitPoints)
        {
            if (newHitPoints <= 0)
            {
                deathReciver.Call();
            }
        }

    }
}