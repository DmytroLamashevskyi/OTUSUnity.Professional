using Assets.Scripts.Components;
using Assets.Scripts.Context;
using Assets.Scripts.Entities;
using Assets.Scripts.Services;
using Entities;
using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts.Controllers
{
    public sealed class CharacterMoveController : MonoBehaviour, IStartGame, IEndGame, IConstructListener
    {
        [ReadOnly]
        [ShowInInspector]
        private const string MOVE_INPUT_KEY = "Movement";

        [SerializeField]
        private int speed;

        private IMoveComponent moveComponent;  

        private InputAction moveInput;

        private void Awake()
        {
            this.enabled = false;
        }

        private void Update()
        {
            var direction = moveInput.ReadValue<Vector3>();
            var velocity = direction * Time.deltaTime * speed;
            moveComponent.Move(velocity); 
        }

        public void Construct(GameContext context)
        {
            moveComponent = context.GetService<CharacterService>().GetCharacter().Get<IMoveComponent>();
            moveInput = context.GetService<UnityEngine.InputSystem.PlayerInput>().actions[MOVE_INPUT_KEY];
        }

        public void OnEndGame()
        {
            this.enabled = false;
        }

        public void OnStartGame()
        {
            this.enabled = true;
        }

    }
}
