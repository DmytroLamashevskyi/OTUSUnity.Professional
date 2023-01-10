using Assets.Scripts.Context;
using Assets.UI.PopupElements.PresenterModels;
using Popups;
using Sirenix.OdinInspector;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.UI.PopupElements.Popups.Player
{
    public class PlayerShower : MonoBehaviour, IConstructListener
    {
        private PlayerCharacteristicsStorage storage;

        private PopupManager popupManager;

        [Button]
        public void Show(Product product)
        {
            var presentationModel = new PlayerPresenterModel(storage);
            popupManager.ShowPopup(PopupName.Player, presentationModel);

        }

        void IConstructListener.Construct(GameContext context)
        {
            popupManager = context.GetService<PopupManager>();
            storage = context.GetService<PlayerCharacteristicsStorage>();
        }


    }
}
