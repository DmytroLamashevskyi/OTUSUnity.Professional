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
        private IntBehaviour speed;

        [SerializeField]
        private Transform gunPosition;
        [SerializeField]
        private GameObject bulletPrefub;


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

            var bulletInstance= Instantiate(bulletPrefub, gunPosition);
            bulletInstance.GetComponent<Rigidbody>().AddForce(Vector3.right * speed.Value);
            countdown.ResetTime();
            countdown.Play();

        } 
    }
}