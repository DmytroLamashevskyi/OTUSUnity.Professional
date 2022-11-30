using Elementary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Mechanic
{
    public sealed class BulletSpawner : MonoBehaviour
    {
        [SerializeField]
        private IntBehaviour speed;

        [SerializeField]
        private Transform gunPosition;
        [SerializeField]
        private GameObject bulletPrefub;

        public void Spawn()
        {


            var bulletInstance = Instantiate(bulletPrefub, gunPosition);
            bulletInstance.GetComponent<Rigidbody>().AddForce(Vector3.right * speed.Value);
        }
    }
}
