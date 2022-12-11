using Assets.Scripts.Components;
using Assets.Scripts.Context;
using Assets.Scripts.Services;
using Entities;
using Mechanic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFallMechanic : MonoBehaviour
{
    [SerializeField]
    private GameContext context; 

    private void Awake()
    {
        //fallComponent = context.GetService<CharacterService>().GetCharacter().Get<IFallComponent>();
    } 
}
