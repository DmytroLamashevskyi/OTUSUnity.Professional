using Assets.Settings.PlayerData;
using Sirenix.OdinInspector;
using System;
using UnityEngine;

namespace Storage
{
    public class PlayerExpStorage : MonoBehaviour
    {
        public event Action<ulong> OnExpChanged;

        [ReadOnly]
        [ShowInInspector]
        private ulong exp;
        public ulong Expexperience { get => this.exp; }

        [SerializeField]
        private LevelSettings levelSettings;
        public int Level { get => levelSettings.GetLevel(this.exp); }

        [Button]
        public void AddExp(ulong money)
        {
            this.exp += money;
            OnExpChanged?.Invoke(this.exp);
        }
    }
}
