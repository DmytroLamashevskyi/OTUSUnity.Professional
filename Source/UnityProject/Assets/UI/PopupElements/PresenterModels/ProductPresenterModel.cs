using Assets.Scripts.Context;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.UI.PopupElements.PresenterModels
{
    public class ProductPresenterModel : IProductPresenterModel
    {
        private readonly ProductBuyer productBuyer; 
        private readonly Product product;

        public ProductPresenterModel(ProductBuyer productBuyer, Product product)
        {
            this.productBuyer = productBuyer; 
            this.product = product;
        }

        public ProductPresenterModel(GameContext context, Product product)
        {
            productBuyer = context.GetService<ProductBuyer>();
            this.product = product; 
        }

        public void BuyProduct()
        {
            productBuyer.Buy(product);
        }

        public string GetDescription()
        {
            return product.description;
        }

        public Sprite GetIcon()
        {
            return product.icon;
        }

        public string GetPrice()
        {
            return product.price.ToString();
        }

        public string GetTitle()
        {
            return product.title;
        }
    }
}
