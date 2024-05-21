using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItems : MonoBehaviour
{
    public ShopManager shopManager; // Reference to the ShopManager script
    public BagManager bagManager; // Reference to the BagManager script
    public Text gameText; // Reference to a UI Text component
    public int amount; // The value of the item
    public Image itemImage; // Reference to the Image component of the item
    //public List<ShopItems> items = new List<itemImages>();
    public void Purchase()
    {
        // Check if the player has enough balance to purchase the item
        if (shopManager.moneyBalance >= amount)
        {
            // Reduce the balance by the value of the selected item
            shopManager.moneyBalance -= amount;
            gameText.text = "Purchase successful. Balance " + shopManager.moneyBalance;

            // Update the balance display
            shopManager.UpdateBalanceDisplay();

            // Instantiate the item image into the bag space
            OnPurchaseComplete();
        }
        else
        {
            gameText.text = "Insufficient balance. Purchase failed.";
        }
    }

    void OnPurchaseComplete()
    {
        // Instantiate the item image into the bag space
        Image newItem = Instantiate(itemImage, bagManager.spacePrefab.transform);
    }
}

    
