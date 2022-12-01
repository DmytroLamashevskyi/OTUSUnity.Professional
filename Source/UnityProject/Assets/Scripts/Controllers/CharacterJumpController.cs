using Assets.Scripts.Components;
using Assets.Scripts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.DefaultInputActions;

namespace Assets.Scripts.Controllers
{
    public class CharacterJumpController : MonoBehaviour
    {

        [SerializeField]
        private Entity entity; 
          
        private void Jump()
        {
            entity.Get<IJumpComponent>().Jump();
        }
        public void OnJump(InputAction.CallbackContext context)
        {
            if (!context.performed)
                return;


            if (context.action.name == "Jump")
            {
                Jump();
            }
        }
    }
} 
