﻿using Elementary;
using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Components
{
    public class AtackComponent : MonoBehaviour, IAtackComponent
    {

        [SerializeField]
        private EventReceiver atackReceiver;
        [Button]
        public void Atack()
        {
            atackReceiver.Call();
        }
    }
}
