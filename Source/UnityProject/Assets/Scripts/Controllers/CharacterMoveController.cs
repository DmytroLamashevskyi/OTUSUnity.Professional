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
    public sealed class CharacterMoveController : MonoBehaviour
    {
        [SerializeField]
        private int speed;
        [SerializeField]
        private Entity entity;
         
        public void OnMove(InputAction.CallbackContext context)
        {
            var direction = context.ReadValue<Vector3>();
            Move(direction);
        }

        private void Move(Vector3 direction)
        {
            var velocity = direction * Time.deltaTime * speed;
            entity.Get<IMoveComponent>().Move(velocity);
        }
    }
}
