using Assets.Scripts.Mechanic;
using Elementary;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
namespace Mechanic
{
    public sealed class ShootMechanic : MonoBehaviour
    {
        [SerializeField]
        private EventReceiver shootReciver;
        [SerializeField]
        private TimerBehaviour countdown;
        [SerializeField]
        private BulletSpawner bulletSpawner;


        private void OnEnable()
        {
            shootReciver.OnEvent += OnRequestAtack;
        }

        private void OnDisable()
        {
            shootReciver.OnEvent -= OnRequestAtack;
        }

        private void OnRequestAtack()
        {
            if (countdown.IsPlaying)
            {
                 return;
            }
            bulletSpawner.Spawn();
            countdown.ResetTime();
            countdown.Play();

        } 
    }
}