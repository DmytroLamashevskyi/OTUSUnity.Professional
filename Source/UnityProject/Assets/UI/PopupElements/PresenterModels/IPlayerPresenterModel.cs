using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.UI.PopupElements.PresenterModels
{
    public interface IPlayerPresenterModel
    {
        void AddAgility();
        void AddIntelect();
        void AddStrength();
        string GetAgility();
        string GetIntellect();
        int GetSkillPoints();
        string GetStength();
    }
}
