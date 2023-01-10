using Storage;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductBuyer : MonoBehaviour
{
    private MoneyStorage moneyStorage;

    public void Buy(Product product)
    { 
        if(moneyStorage.Money > product.price)
        { 
            moneyStorage.SpendMoney(product.price);
        }
        else
        {
            throw new Exception("Not enougth Money");
        }
    }
}
