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
    public class TakeDamageComponent:MonoBehaviour,ITakeDamageComponent
    { 
        [SerializeField]
        private EventReceiver_Int takeDamageReceiver;

        [Button]
        public void TakeDamage(int damage)
        {
            takeDamageReceiver.Call(damage);
        }
    }
}
