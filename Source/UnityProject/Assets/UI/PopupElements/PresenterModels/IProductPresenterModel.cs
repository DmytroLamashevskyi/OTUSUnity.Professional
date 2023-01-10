using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.UI.PopupElements.PresenterModels
{
    public interface IProductPresenterModel
    {
        void BuyProduct();
        string GetDescription();
        Sprite GetIcon();
        string GetPrice();
        string GetTitle();
    }
}
