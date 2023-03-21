using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchasingManager : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="i"></param>
    public void OnPressDown(int i)
    {
        ///
        switch (i)
        {
            case 3: ///
                IAPManager.OnPurchaseSuccess = () =>
                    GameDataManager.Ins.player.AddToyNe(50);
                ///
                IAPManager.Ins.BuyProductID(IAPKey.PACK3);
                break;
            case 4: ///
                IAPManager.OnPurchaseSuccess = () =>
                    GameDataManager.Ins.player.AddToyNe(100);
                
                IAPManager.Ins.BuyProductID(IAPKey.PACK4);
                break;
            case 5: ///
                IAPManager.OnPurchaseSuccess = () =>
                    GameDataManager.Ins.player.AddToyNe(200);
                ////
                IAPManager.Ins.BuyProductID(IAPKey.PACK5);
                break;
            case 1:
                IAPManager.OnPurchaseSuccess = () =>
                    GameDataManager.Ins.player.AddToyNe(10);
                //////////////
                IAPManager.Ins.BuyProductID(IAPKey.PACK1);
                break;
            ///
            case 2:
                IAPManager.OnPurchaseSuccess = () =>
                    GameDataManager.Ins.player.AddToyNe(20);
                ////////////////
                IAPManager.Ins.BuyProductID(IAPKey.PACK2);
                break;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="i"></param>
    public void Sub(int i)
    {
        GameDataManager.Ins.player.SubToy(i);
    }
}