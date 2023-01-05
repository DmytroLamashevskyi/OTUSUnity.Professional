using Assets.Scripts.Mechanic;
using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Components
{

    public class GetPositionComponent : MonoBehaviour, IGetPositionComponent
    { 
        [SerializeField]
        private PositionMechanic bodyPosition;
        public Vector3 GetPosition()
        {
            return bodyPosition.GetBodyPosition();
        }
    }
}
