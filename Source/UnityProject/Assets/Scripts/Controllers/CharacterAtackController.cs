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

namespace Assets.Scripts.Controllers
{
    public class CharacterAtackController : MonoBehaviour , IStartGame, IEndGame, IConstructListener
    { 
        private IAtackComponent atackComponent;

        private event OnAtackHandler AtackHandler;
        private delegate void OnAtackHandler();

        void IConstructListener.Construct(GameContext context)
        {
            atackComponent = context.GetService<CharacterService>().GetCharacter().Get<IAtackComponent>();
        }
        void IStartGame.OnStartGame()
        {
            AtackHandler += Atack;
        }
        void IEndGame.OnEndGame()
        {
            AtackHandler -= Atack;
        }

        public void OnAtack(InputAction.CallbackContext context)
        {
            if (!context.performed)
                return;
            if (context.action.name == "Atack")
            {
                AtackHandler?.Invoke();
            }
        }

        private void Atack()
        {
            atackComponent.Atack();
        }
    }
}
