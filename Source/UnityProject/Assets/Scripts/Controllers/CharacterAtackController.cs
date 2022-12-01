using Assets.Scripts.Components;
using Assets.Scripts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts.Controllers
{
    public class CharacterAtackController : MonoBehaviour
    {

        [SerializeField]
        private Entity entity; 
         

        public void OnAtack(InputAction.CallbackContext context)
        {
            if (!context.performed)
                return;
            if (context.action.name == "Atack")
            {
                Atack();
            }
        }

        private void Atack()
        {
            entity.Get<IAtackComponent>().Atack();
        }
    }
}
