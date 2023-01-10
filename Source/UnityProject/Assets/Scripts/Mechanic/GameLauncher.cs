using Assets.Scripts.Context;
using Elementary;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLauncher : MonoBehaviour
{
    [SerializeField]
    private TimerBehaviour countdown;
    [SerializeField]
    private GameContext context;

    private void OnEnable()
    {
        context.ConstructServices();
        countdown.OnFinished +=StartGame;
    }

    private void OnDisable()
    {
        countdown.OnFinished -=StartGame;
    }

    [Button]
    private void OnStartGame()
    {
        countdown.Play(); 
    } 

    private void StartGame()
    {
        Debug.Log("Game Started");
        context.GameStart();
    }
}
