using Elementary;
using Mechanic;
using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public sealed class MoveComponent : MonoBehaviour, IMoveComponent
    { 

        [SerializeField]
        private EventReceiver_Vector3 moveReceiver;

        [Button]
        public void Move(Vector3 direction)
        {
            moveReceiver.Call(direction);
        }
    }
}
