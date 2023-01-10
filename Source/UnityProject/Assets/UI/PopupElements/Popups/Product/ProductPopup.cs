using Assets.Scripts.Context;
using Assets.UI.PopupElements.PresenterModels;
using Popups;
using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ProductPopup : Popup
{ 
    [SerializeField]
    private TextMeshProUGUI _titleText;
    [SerializeField]
    private TextMeshProUGUI _descriptionText;
    [SerializeField]
    private Image _iconImage;
    [SerializeField]
    private Button _buyButton;
    [SerializeField]
    private TextMeshProUGUI _buyText;

    private IProductPresenterModel _productPresenter; 

    protected override void OnShow(object args)
    {
        if(args is not IProductPresenterModel presenter)
        { 
            throw new Exception("Wrong argument");
        }
        _productPresenter = presenter;

        _titleText.text = _productPresenter.GetTitle();
        _descriptionText.text = _productPresenter.GetDescription();
        _iconImage.sprite = _productPresenter.GetIcon();
        _buyText.text = _productPresenter.GetPrice();

        _buyButton.onClick.AddListener(_productPresenter.BuyProduct);
    } 

    protected override void OnHide()
    {
        _buyButton.onClick.RemoveListener(_productPresenter.BuyProduct);
    }
     
}
