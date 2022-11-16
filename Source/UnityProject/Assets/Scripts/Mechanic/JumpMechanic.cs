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
        private EventReceiver_Collision jumpCollisionReciver;

        [SerializeField]
        private BoolBehaviour isJumping;

        private void OnEnable()
        {
            jumpReciver.OnEvent += OnJumpEventRecived;
            jumpCollisionReciver.OnCollisionEntered += OnGroundFall;
        }

        private void OnDisable()
        {
            jumpReciver.OnEvent -= OnJumpEventRecived;
            jumpCollisionReciver.OnCollisionEntered -= OnGroundFall;
        }

        private void OnJumpEventRecived()
        {
            if (!isJumping.Value)
            {
                isJumping.AssignTrue();
                jumpCollisionReciver.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 10, ForceMode.Impulse);
            }
        }

        private void OnGroundFall(Collision obj)
        {
            if(obj.gameObject.tag == "Ground")
            { 
                isJumping.AssignFalse();
            }
        }

    }
}