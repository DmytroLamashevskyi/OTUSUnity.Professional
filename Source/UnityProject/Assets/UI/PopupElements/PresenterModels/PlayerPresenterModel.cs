using Assets.Scripts.Context;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.UI.PopupElements.PresenterModels
{
    public class PlayerPresenterModel: IPlayerPresenterModel
    {
        private PlayerCharacteristicsStorage _characteristicsStorage;

        public PlayerPresenterModel(PlayerCharacteristicsStorage characteristicsStorage)
        {
            _characteristicsStorage = characteristicsStorage;
        }

        public void AddAgility()
        {
            _characteristicsStorage.AddAgility(1);
        }

        public void AddIntelect()
        {
            _characteristicsStorage.AddIntellect(1);
        }

        public void AddStrength()
        {
            _characteristicsStorage.AddStrengths(1);
        }

        public string GetAgility()
        {
            return _characteristicsStorage.Agility.ToString();
        }

        public string GetIntellect()
        {
            return _characteristicsStorage.Intellect.ToString();
        }

        public int GetSkillPoints()
        {
            return _characteristicsStorage.SkillPoints;
        }

        public string GetStength()
        {
            return _characteristicsStorage.Strengths.ToString();
        }

         
    }
}
