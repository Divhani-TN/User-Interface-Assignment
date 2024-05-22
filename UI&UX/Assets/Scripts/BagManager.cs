using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BagManager : MonoBehaviour
{
    public Button BagButton;
    public GridLayoutGroup layoutGroup;
    public GameObject spacePrefab;
    private int buttonPressCount = 0;
    public int price;
 
    // Reference to the ShopManager script
    public ShopManager shopManager;
    public List<GameObject> bagSpaces = new List<GameObject>();
    public ShopItems shopItems;
    public GameObject[] Slots;

    void Start()
    {
      
        BagButton.onClick.AddListener(AddSpaces);
        shopItems = GameObject.FindGameObjectWithTag("Wahtever").GetComponent<ShopItems>();
    }
    public void AddSpaces()
    {
        Debug.Log("Button clicked");

        if (shopManager.moneyBalance < 25)
        {
            Debug.Log("Insufficient balance");
            return;
        }

        buttonPressCount++;

        if (buttonPressCount > 1)
        {
            BagButton.gameObject.SetActive(false);
            return;
        }

        // Reduce the balance by 25
        shopManager.ReduceBalance(25);
        Debug.Log("Balance after reduction: " + shopManager.moneyBalance);

        // Add new spaces to the layout group
        for (int i = 0; i < layoutGroup.constraintCount; i++)
        {
            GameObject newSpace = Instantiate(spacePrefab);
            newSpace.transform.SetParent(layoutGroup.transform, false);
        }
    }
    public void CheckEmpty(Image itemImage)
    {
        foreach (Transform space in layoutGroup.transform)
        {
            // Check if the space is empty
            if (space.childCount == 0)
            {
                // The space is empty, so add the item here
                Image newItem = Instantiate(itemImage, space);
                return;
            }
        }
        Debug.Log("All spaces are full. No new item was added.");

    }
    public void SellItem()
    {

  
    }
    public void movetoChest()
    {

    }
   
    
}

