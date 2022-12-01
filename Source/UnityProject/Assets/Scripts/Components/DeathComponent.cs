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
    public class DeathComponent:MonoBehaviour, IDeathComponent
    {
        [SerializeField]
        private EventReceiver deathReceiver;
        [Button]
        public void Death()
        {
            deathReceiver.Call();
        }
    }
}
