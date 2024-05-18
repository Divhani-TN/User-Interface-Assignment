using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// Start is called before the first frame update
public class Game1 : MonoBehaviour
{
    public GameObject Chest;
    public GameObject Bag;
    public Button ChestButton; // Reference to the button
    public Button BagButton;

    void Start()
    {
        Chest.SetActive(false);
        Bag.SetActive(true);

        // Add a listener to the chest button
        ChestButton.onClick.AddListener(ActivateChest);

        // Add a listener to the bag button
        BagButton.onClick.AddListener(ActivateBag);
    }

    // Update is called once per frame
    void Update()
    {
        if (Chest.activeSelf == true)
        {
            Bag.SetActive(false);
        }
    }

    // Method to activate the Chest
    void ActivateChest()
    {
        Chest.SetActive(true);
    }

    // Method to activate the Bag and deactivate the Chest
    void ActivateBag()
    {
        Chest.SetActive(false);
        Bag.SetActive(true);
    }
}
