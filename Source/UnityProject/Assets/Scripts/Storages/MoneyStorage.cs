using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics; 
using UnityEngine;

namespace Storage
{
    public class MoneyStorage : MonoBehaviour
    {
        public event Action<ulong> OnMoneyChanged;

        [ReadOnly]
        [ShowInInspector]
        private ulong money;
        public ulong Money { get => this.money; }

        [Button]
        public void AddMoney(ulong money)
        {
            this.money += money;
            OnMoneyChanged?.Invoke(this.money);
        }

        [Button]
        public void SpendMoney(ulong money) 
        {
            this.money -= money;
            OnMoneyChanged?.Invoke(this.money);
        }
    }
}
