using Assets.Scripts.Context;
using Assets.UI.PopupElements.PresenterModels;
using Popups;
using Sirenix.OdinInspector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class ProductShower : MonoBehaviour, IConstructListener
{
    private PopupManager popupManager;

    private ProductBuyer productBuyer;

    [Button]
    public void Show(Product product)
    {
        var presentationModel = new ProductPresenterModel(productBuyer,product);
        popupManager.ShowPopup(PopupName.Product,presentationModel);

    }

    void IConstructListener.Construct(GameContext context)
    {
        popupManager = context.GetService<PopupManager>();
        productBuyer = context.GetService<ProductBuyer>();
    }
}
