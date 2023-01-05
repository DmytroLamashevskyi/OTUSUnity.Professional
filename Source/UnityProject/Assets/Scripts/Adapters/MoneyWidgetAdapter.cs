using Assets.Scripts.Context; 
using Storage;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Widget.Money;

namespace WidgetAdapters
{
    public class MoneyWidgetAdapter : MonoBehaviour, IStartGame, IEndGame, IConstructListener
    {

        [SerializeField]
        private MoneyWidget widget;

        private MoneyStorage storage;

        void IConstructListener.Construct(GameContext context)
        {
            storage = context.GetService<MoneyStorage>();
            widget.Setup(storage.Money.ToString());
        }
        void IStartGame.OnStartGame()
        {
            storage.OnMoneyChanged += UpdateMoney;
        }

        void IEndGame.OnEndGame()
        {
            storage.OnMoneyChanged -= UpdateMoney;
        }

        private void UpdateMoney(ulong value)
        {
            widget.UpdateMoney(value.ToString());
        }

    }

}