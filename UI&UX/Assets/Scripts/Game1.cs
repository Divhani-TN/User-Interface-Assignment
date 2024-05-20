using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Start is called before the first frame update
public class Game1 : MonoBehaviour
{
    public GameObject Chest;
    //public GameObject Bag;
    public Button ChestButton; // Reference to the button
    public Button ShopButton;
    public GameObject Shoppanel;

    void Start()
    {
        Chest.SetActive(false);
        

        // Add a listener to the chest button
        ChestButton.onClick.AddListener(ActivateChest);

        // Add a listener to the bag button
        ShopButton.onClick.AddListener(ActivateShop);
    }

    // Update is called once per frame
    void Update()
    {
        if (Chest.activeSelf == true)
        {
            Shoppanel.SetActive(false);
        }
    }

    // Method to activate the Chest
    void ActivateChest()
    {
        Chest.SetActive(true);
        Shoppanel.SetActive(false);
    }

    // Method to activate the Bag and deactivate the Chest
    void ActivateShop()
    {
        Shoppanel.SetActive(true);
        Chest.SetActive(false);
    }
}
