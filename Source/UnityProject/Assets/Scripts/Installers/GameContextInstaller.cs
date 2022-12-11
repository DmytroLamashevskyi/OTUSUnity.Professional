using Assets.Scripts.Context;
using Assets.Scripts.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Installers
{
    public sealed class GameContextInstaller : MonoBehaviour
    {
        [SerializeField]
        private GameContext context;

        [Space]
        [SerializeField]
        private MonoBehaviour[] listeners;


        public void Awake()
        {
            foreach (var listener in listeners)
            {
                context.AddListener(listener);
            }
        }

    }
}
