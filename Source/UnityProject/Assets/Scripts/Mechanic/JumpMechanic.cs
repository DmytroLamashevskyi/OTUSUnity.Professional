using Elementary;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
namespace Mechanic
{
    public sealed class JumpMechanic : MonoBehaviour
    {
        [SerializeField]
        private EventReceiver jumpReciver;

        [SerializeField]
        private BoolBehaviour isGrounded;

        [SerializeField]
        private Rigidbody rigidbody;

        private void OnEnable()
        {
            jumpReciver.OnEvent += OnJumpEventRecived; 
        }

        private void OnDisable()
        {
            jumpReciver.OnEvent -= OnJumpEventRecived; 
        }

        private void OnJumpEventRecived()
        {
            if (isGrounded.Value)
            { 
                rigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse);
            }
        }


    }
}