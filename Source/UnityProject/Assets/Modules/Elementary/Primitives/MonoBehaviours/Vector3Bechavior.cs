using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  
namespace Elementary
{
    [AddComponentMenu("Elementary/Vector3")]
    public sealed class Vector3Bechavior : MonoBehaviour
    {
        public event Action<Vector3> OnValueChanged;

        public Vector3 Value
        {
            get { return this.value; }
            set { 
                this.value = value;
                this.OnValueChanged?.Invoke(value);
            }
        }

        [SerializeField]
        private Vector3 value;

        [Title("Methods")]
        [GUIColor(0, 1, 0)]
        [Button]
        public void Set(Vector3 value)
        {
            this.value = value;
            this.OnValueChanged?.Invoke(value);
        }
         
    }
}