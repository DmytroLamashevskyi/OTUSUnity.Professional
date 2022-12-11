using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Assets.Scripts.Context
{
    public class GameContext : MonoBehaviour
    {
        [ReadOnly]
        [ShowInInspector]
        private readonly List<object> listeners = new();

        public  T GetService<T>()
        {
            foreach (var listener in listeners)
            {
                if (listener is T service)
                {
                    return service;
                }
            }

            throw new ArgumentException($"Service {typeof(T).Name} wasn't found in Game Context.");
        }


        public void AddListener(object listener)
        {
            listeners.Add(listener);
        }

        public void RemoveListener(object listener)
        {
            listeners.Remove(listener);
        }
         
        public void ConstructServices()
        {
            foreach (var listener in listeners)
            {
                if (listener is IConstructListener constructListener)
                {
                    constructListener.Construct(this);
                }
            }
        }
         
        public void GameStart()
        {
            foreach (var listener in listeners)
            {
                if(listener is IStartGame startGame)
                {
                    startGame.OnStartGame();
                }
            }

            Debug.Log("Game Started");
        }
         
        public void EndGame()
        {
            foreach (var listener in listeners)
            {
                if (listener is IEndGame endGame)
                {
                    endGame.OnEndGame();
                }
            }

            Debug.Log("Game Ended");
        }

    }
}
