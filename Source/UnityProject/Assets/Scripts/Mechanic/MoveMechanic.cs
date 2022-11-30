using Elementary;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Mechanic
{
    public sealed class MoveMechanic : MonoBehaviour
    {
        [SerializeField]
        private EventReceiver_Vector3 vectorReciver;

        [SerializeField]
        private Vector3Bechavior bodyPosition; 

        private void OnEnable()
        {
            vectorReciver.OnEvent += OnMoveVector;
        }

        private void OnDisable()
        {
            vectorReciver.OnEvent -= OnMoveVector;
        }

        private void OnMoveVector(Vector3 newVector)
        {
            bodyPosition.Value += newVector; 
        }

    }
}