
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ShopManager : MonoBehaviour
{
    public int moneyBalance = 100;
    public Text moneyBalanceText; // Text object to display the balance
    public GameObject Spot;

    public GameObject[] Slots;
    public ShopItems ShopItems;
    void Start()
    {
        // Initialize money balance
        moneyBalance = 100;
       

    }

    public bool PurchaseItem(int cost)
    {
        foreach (GameObject obj in Slots)
        {
            if (obj.transform.childCount == 0)
            {
                if (obj.GetComponent<Snap>().haschildren == false)
                {
                     // Instantiate the item image into the bag space
        Image newItem = Instantiate(ShopItems.itemImage,ShopItems.bagManager.spacePrefab.transform);
                    newItem.tag = "image";
                    newItem.transform.SetParent(obj.transform);
                    newItem.transform.position = obj.transform.position;
                }
            }
        }
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

    public void IncreaseBalance(int amount)
    {
        // Get the BagManager script
        BagManager bagManager = GetComponent<BagManager>();

        // Check if there are any items in the BagSpace prefab
        Image[] bagItems = bagManager.layoutGroup.GetComponentsInChildren<Image>();

        // If there are no items, return null
        if (bagItems.Length == 0)
        {
            Debug.Log("No items in the bag.");
            return;
        }

        // If there are items, increase the balance
        moneyBalance += amount;
        
        Debug.Log("Balance after increase: " + moneyBalance);
    }
    public void Update()
    {
        // Update the text object to display the current balance
        moneyBalanceText.text = "Balance: $" + moneyBalance.ToString();

        // Check if the balance is 0
        if (moneyBalance == 0)
        {
            // If the balance is 0, the game is over
            Debug.Log("Game Over. Balance is 0.");

            // Load the "Lost" scene
            SceneManager.LoadScene("Lost");
        }


    }
    public void Selling(int cost)
    {
        moneyBalance += cost;
    }
}


