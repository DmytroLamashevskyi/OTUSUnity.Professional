using Elementary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Mechanic
{
    public class ConnectorColiderVisual : MonoBehaviour
    {
        [SerializeField]
        private Transform rigidbodyTransform;
        [SerializeField]
        private Vector3Bechavior bodyPosition; 

        private void FixedUpdate()
        {
            bodyPosition.Set(rigidbodyTransform.position);
        } 

    }
} 