using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Settings.PlayerData
{
    [CreateAssetMenu(fileName = "LevelSettings", menuName = "PlayerData/Level Settings")]
    public class LevelSettings : ScriptableObject
    {
        [SerializeField]
        public LevelData[] LevelMap;

        public int GetLevel(ulong exp)
        {
            var data= LevelMap.Where(x => x.exp < exp).Max();
            return data.level;
        }
    }
    [Serializable]
    public class LevelData
    {
        public int level;
        public uint exp;
    }
}
