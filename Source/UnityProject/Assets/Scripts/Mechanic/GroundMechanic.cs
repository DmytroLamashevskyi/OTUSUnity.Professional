using Elementary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Mechanic
{
    public sealed class GroundMechanic : MonoBehaviour
    {

        [SerializeField]
        private BoolBehaviour isGrounded;
        [SerializeField]
        private EventReceiver_Collision collisionReceiverr;
        [SerializeField]
        private string colisionTagName;

        private void OnEnable()
        {
            collisionReceiverr.OnCollisionExited += OnCollisionExited;
            collisionReceiverr.OnCollisionEntered += OnCollisionEntered; 
        }

        private void OnDisable()
        {
            collisionReceiverr.OnCollisionExited -= OnCollisionExited;
            collisionReceiverr.OnCollisionEntered -= OnCollisionEntered;
        }

        private void OnCollisionEntered(Collision obj)
        {
            if (obj.gameObject.tag == colisionTagName)
            {
                isGrounded.AssignTrue();
            }
        }
        private void OnCollisionExited(Collision obj)
        {
            if (obj.gameObject.tag == colisionTagName)
            {
                isGrounded.AssignFalse();
            }
        }
    }
}
