using Assets.Scripts.Context;
using Elementary;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameMechanic : MonoBehaviour
{
    [SerializeField]
    private TimerBehaviour countdown;
    [SerializeField]
    private GameContext context;

    private void Awake()
    {
        countdown.OnFinished +=StartGame;
    }

    [Button]
    private void OnStartGame()
    {
        countdown.Play(); 
    } 

    private void StartGame()
    {
        Debug.Log("Game Started");
        context.ConstructServices();
        context.GameStart();
    }
}
