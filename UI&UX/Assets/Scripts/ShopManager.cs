
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public int moneyBalance = 100;
    public Text moneyBalanceText; // Text object to display the balance


    void Start()
    {
        // Initialize money balance
        moneyBalance = 100;
        UpdateBalanceDisplay();
        
    }

    public bool PurchaseItem(int cost)
    {
        // Check if there is enough money to purchase the item
        if (moneyBalance >= cost)
        {
            // Deduct the cost from the money balance
            moneyBalance -= cost;
            // UpdateBalanceDisplay();

            // Return true to indicate that the purchase was successful
            return true;
        }
        else
        {
            // If not enough money, do not make a purchase and return false
            Debug.Log("Not enough money to make the purchase.");
            return false;
        }
    }
    public void ReduceBalance(int amount)
    {
        moneyBalance -= amount;
        UpdateBalanceDisplay();
    }
    public GameObject GetShopItem()
    {
        // Find all game objects tagged as ShopItem
        GameObject[] shopItems = GameObject.FindGameObjectsWithTag("ShopItem");

        // If there are any shop items, return the first one
        if (shopItems.Length > 0)
        {
            return shopItems[0];
        }

        // If there are no shop items, return null
        return null;
    }

    public void UpdateBalanceDisplay()
    {
        // Update the text object to display the current balance
        moneyBalanceText.text = "Balance: $" + moneyBalance.ToString();
    }
}


