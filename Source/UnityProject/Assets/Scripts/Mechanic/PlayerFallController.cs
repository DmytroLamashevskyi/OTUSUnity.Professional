using Assets.Scripts.Components;
using Assets.Scripts.Context;
using Assets.Scripts.Services; 
using UnityEngine;

public class PlayerFallController : MonoBehaviour
{ 
    [SerializeField]
    private float height;

    [SerializeField]
    private GameContext context;

    private IGetPositionComponent position;

    private void OnEnable()
    {
        position = context.GetService<CharacterService>().GetCharacter().Get<IGetPositionComponent>();
    }

    private void FixedUpdate()
    {
        if(position.GetPosition().y < height)
        {
            context.EndGame();
        }
    }
}
