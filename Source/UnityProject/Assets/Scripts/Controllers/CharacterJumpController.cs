using Assets.Scripts.Components;
using Assets.Scripts.Context;
using Assets.Scripts.Entities;
using Assets.Scripts.Services;
using Entities;
using Sirenix.OdinInspector;
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
        [ReadOnly]
        [ShowInInspector]
        private const string JUMP_INPUT_KEY = "Jump";

        private IJumpComponent jumpComponent;

        private InputAction jumpInput;

        void IConstructListener.Construct(GameContext context)
        {
            jumpComponent = context.GetService<CharacterService>().GetCharacter().Get<IJumpComponent>();
            jumpInput = context.GetService<UnityEngine.InputSystem.PlayerInput>().actions[JUMP_INPUT_KEY];
        }

        void IStartGame.OnStartGame()
        {
            this.enabled = true;
            jumpInput.performed += Jump;
        }

        void IEndGame.OnEndGame()
        {
            this.enabled = false;
            jumpInput.performed -= Jump;
        }

        private void Jump(InputAction.CallbackContext context)
        {
            jumpComponent.Jump();
        } 
    }
} 
