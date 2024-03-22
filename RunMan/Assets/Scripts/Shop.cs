using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] CoinManagere _coinManagere;
    PlayerModofier _playerModofier;

    private void Start()
    {
        _playerModofier = FindObjectOfType<PlayerModofier>();
    }
   public void BuyWidth()
   {
    if(_coinManagere.NumberOfCoins >= 100)
    {
        _coinManagere.SpendMoney(100);
        Progress.Instance.Coins = _coinManagere.NumberOfCoins;
        Progress.Instance.Width += 25;
        _playerModofier.SetWidth(Progress.Instance.Width);
    }
   }

   public void BuyHeight()
   {
    if(_coinManagere.NumberOfCoins >= 100)
    {
        _coinManagere.SpendMoney(100);
        Progress.Instance.Coins = _coinManagere.NumberOfCoins;
        Progress.Instance.Height += 25;
        _playerModofier.SetHeight(Progress.Instance.Height);
    }
   }
}
