using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static UnityEditor.Progress;


namespace Assets.Scripts.Components
{
    public class Entity : MonoBehaviour
    {
        [SerializeField]
        private MonoBehaviour[] components;

        public T Get<T>() 
        {
            foreach (var component in components)
            {
                if (component is T result)
                {
                    return result;
                }
            }

            throw new MissingComponentException($"Component of type {typeof(T).Name} wasn't founded.");
        }

        public bool TryGet<T>(out T result) 
        {
            foreach (var component in components)
            {
                if (component is T resultComponent)
                {
                    result = resultComponent;
                    return true;
                }
            }
            result = default;
            return false;
        }
            

    }
}
