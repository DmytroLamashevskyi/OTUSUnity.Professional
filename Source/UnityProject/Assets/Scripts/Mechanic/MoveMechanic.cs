using Assets.Scripts.Context;
using Elementary;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;


namespace Mechanic
{

    public sealed class MoveMechanic : MonoBehaviour
    {
        [SerializeField]
        private EventReceiver_Vector3 vectorReciver;

        [SerializeField]
        private Rigidbody bodyPosition; 

        void OnEnable()
        {
            vectorReciver.OnEvent += OnMoveVector;
        }

        void OnDisable()
        {
            vectorReciver.OnEvent -= OnMoveVector;
        }

        private void OnMoveVector(Vector3 newVector)
        {
            bodyPosition.MovePosition(bodyPosition.position + newVector);
        }

    }
}