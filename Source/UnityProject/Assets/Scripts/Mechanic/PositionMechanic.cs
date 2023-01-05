using Elementary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Mechanic
{
    public class PositionMechanic: MonoBehaviour
    {
        [SerializeField]
        private Transform bodyPosition; 

        public Vector3 GetBodyPosition()
        {
            return bodyPosition.position;
        }

    }
}
