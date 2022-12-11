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
        [SerializeField]
        private int speed;

        private IMoveComponent moveComponent;

        private event OnMoveHandler MoveHandler;
        private delegate void OnMoveHandler(Vector3 direction);

        void IConstructListener.Construct(GameContext context)
        {
            moveComponent = context.GetService<CharacterService>().GetCharacter().Get<IMoveComponent>();
        } 

        void IStartGame.OnStartGame()
        {
            MoveHandler += Move;
        }
        void IEndGame.OnEndGame()
        {
            MoveHandler -= Move;
        }
        //Метод который добавленн в инспекторе к инпут системе
        public void OnMove(InputAction.CallbackContext context)
        {
            var direction = context.ReadValue<Vector3>();
            MoveHandler?.Invoke(direction);
        }

        //Метод который двигает Ентити 
        private void Move(Vector3 direction)
        {
            var velocity = direction * Time.deltaTime * speed;
            moveComponent.Move(velocity);
        }

    }
}
