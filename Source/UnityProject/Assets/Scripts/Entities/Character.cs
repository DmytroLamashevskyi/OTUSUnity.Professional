using Elementary;
using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Entities
{
    public class Character : MonoBehaviour
    {
        [SerializeField]
        private IntBehaviour hitPoints;
        public int HitPoints
        {
            get { return hitPoints.Value; }
        }
        public event Action<int> onHitPointsChanged
        {
            add { this.hitPoints.OnValueChanged += value; }
            remove { this.hitPoints.OnValueChanged -= value; }
        } 


         

    }
}

