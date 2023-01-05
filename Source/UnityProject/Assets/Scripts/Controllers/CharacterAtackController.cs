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

namespace Assets.Scripts.Controllers
{
    public class CharacterAtackController : MonoBehaviour , IStartGame, IEndGame, IConstructListener
    { 

        [ReadOnly]
        [ShowInInspector]
        private const string ATACK_INPUT_KEY = "Atack";

        private IAtackComponent atackComponent;

        private InputAction atackInput;

        void IConstructListener.Construct(GameContext context)
        {
            atackComponent = context.GetService<CharacterService>().GetCharacter().Get<IAtackComponent>();
            atackInput = context.GetService<UnityEngine.InputSystem.PlayerInput>().actions[ATACK_INPUT_KEY];
        }
        void IStartGame.OnStartGame()
        {
            this.enabled = true;
            atackInput.performed += Atack;
        }
        void IEndGame.OnEndGame()
        {
            this.enabled = true;
            atackInput.performed += Atack;
        }
         

        private void Atack(InputAction.CallbackContext context)
        {
            atackComponent.Atack();
        }
    }
}
