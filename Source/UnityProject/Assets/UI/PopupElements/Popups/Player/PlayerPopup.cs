using Assets.Scripts.Context;
using Assets.UI.PopupElements.PresenterModels;
using Storage;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Popups
{ 
    public class PlayerPopup : Popup
    {
        [SerializeField]
        private TextMeshProUGUI playerName; 

        [SerializeField]
        private TextMeshProUGUI strText;
        [SerializeField]
        private Button addStrButton;
        [SerializeField]
        private TextMeshProUGUI aglText;
        [SerializeField]
        private Button addAglButton;
        [SerializeField]
        private TextMeshProUGUI intText;
        [SerializeField]
        private Button addIntButton;

        private IPlayerPresenterModel playerPresenter;


        protected override void OnShow(object args)
        {
            if (args is not IPlayerPresenterModel presenter)
            {
                throw new Exception("Wrong argument");
            }
            playerPresenter = presenter; 

            strText.text = playerPresenter.GetStength();
            aglText.text = playerPresenter.GetAgility();
            intText.text = playerPresenter.GetIntellect();
            addStrButton.onClick.AddListener(playerPresenter.AddStrength);
            addAglButton.onClick.AddListener(playerPresenter.AddAgility);
            addIntButton.onClick.AddListener(playerPresenter.AddIntelect);

            if(playerPresenter.GetSkillPoints() == 0)
            {
                addStrButton.gameObject.SetActive(false);
                addAglButton.gameObject.SetActive(false);
                addIntButton.gameObject.SetActive(false);
            }
            else
            {
                addStrButton.gameObject.SetActive(true);
                addAglButton.gameObject.SetActive(true);
                addIntButton.gameObject.SetActive(true);
            }
        }

        protected override void OnHide()
        {
            addStrButton.onClick.RemoveListener(playerPresenter.AddStrength);
            addAglButton.onClick.RemoveListener(playerPresenter.AddAgility);
            addIntButton.onClick.RemoveListener(playerPresenter.AddIntelect);
        } 
    }
}
