using Elementary;
using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public class JumpComponent : MonoBehaviour, IJumpComponent
    {
        [SerializeField]
        private EventReceiver jumpReceiver;
        [Button]
        public void Jump()
        {
            jumpReceiver.Call();
        }
    }
}
