using Assets.Scripts.Components;
using Assets.Scripts.Context;
using Assets.Scripts.Entities;
using Assets.Scripts.Services;
using Entities;
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
    public class CharacterJumpController : MonoBehaviour, IStartGame, IEndGame, IConstructListener
    {
        private IJumpComponent jumpComponent;
        private event OnJumpHandler JumpHandler;
        private delegate void OnJumpHandler();

        void IConstructListener.Construct(GameContext context)
        {
            jumpComponent = context.GetService<CharacterService>().GetCharacter().Get<IJumpComponent>();
        }
        void IStartGame.OnStartGame()
        {
            JumpHandler += Jump;
        }
        void IEndGame.OnEndGame()
        {
            JumpHandler -= Jump;
        }

        private void Jump()
        {
            jumpComponent.Jump();
        }
        public void OnJump(InputAction.CallbackContext context)
        {
            if (!context.performed)
                return; 
            if (context.action.name == "Jump")
            {
                JumpHandler?.Invoke();
            }
        }
    }
} 
