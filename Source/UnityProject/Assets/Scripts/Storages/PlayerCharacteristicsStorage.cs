using Sirenix.OdinInspector;
using System;
using UnityEngine;

namespace Storage
{
    public class PlayerCharacteristicsStorage : MonoBehaviour
    {
        public event Action<int> OnStrengthsChanged;
        public event Action<int> OnAgilityChanged;
        public event Action<int> OnIntellectChanged;

        public event Action<int> OnPointsChanged;

        [ReadOnly]
        [ShowInInspector]
        private int strengths;
        [ReadOnly]
        [ShowInInspector]
        private int agility;
        [ReadOnly]
        [ShowInInspector]
        private int intellect;
        [ReadOnly]
        [ShowInInspector]
        private int freePoints;

        public int Strengths { get => this.strengths; }
        public int Agility { get => this.agility; }
        public int Intellect { get => this.intellect; }
        public int SkillPoints { get => this.freePoints; }

        [Button]
        public void AddPoints(int value)
        {
            freePoints += value;
            OnPointsChanged?.Invoke(this.freePoints);
        }

        [Button]
        public void AddStrengths(int value)
        {
            if (!IsCanSpendPoints(value))
            {
                throw new Exception("Not enougth skillpoints");
            }
            strengths += value;
            freePoints -= value;
            OnStrengthsChanged?.Invoke(this.strengths);
        }

        [Button]
        public void AddAgility(int value)
        {
            if (!IsCanSpendPoints(value))
            {
                throw new Exception("Not enougth skillpoints");
            }
            agility += value;
            freePoints -= value;
            OnAgilityChanged?.Invoke(this.agility);
        }

        [Button]
        public void AddIntellect(int value)
        {
            if (!IsCanSpendPoints(value))
            {
                throw new Exception("Not enougth skillpoints");
            }
            intellect += value;
            freePoints -= value;
            OnIntellectChanged?.Invoke(this.intellect);
        }

        private bool IsCanSpendPoints(int spendPoints)
        {
            return freePoints >= spendPoints;
        }

    }
}
