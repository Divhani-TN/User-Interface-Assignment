using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChestManager : MonoBehaviour
{

    public Button yourButton;
    public GridLayoutGroup layoutGroup;
    public GameObject spacePrefab;
    private int buttonPressCount = 0;

    public ShopManager shopManager;
    public bool hasChildren;
   // public BagManager BagManager;
    //public ShopItems itemimage;
    void Start()
    {
        yourButton.onClick.AddListener(AddSpaces);
    }
    public void AddSpaces()
    {

        if (shopManager.moneyBalance < 25)
        {
            Debug.Log("Insufficient balance");
            return;
        }

        buttonPressCount++;

        if (buttonPressCount > 1)
        {
            yourButton.gameObject.SetActive(false);
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

    public void CheckEmpty()
    {
        foreach (Transform space in layoutGroup.transform)
        {
            if (space.childCount > 0)
            {
                Debug.Log("Space taken");
            }
        }
    }
    public void Update()
    {
        hasChildren = transform.childCount > 0;
    }
    public void movebacktobag()
    {

    }
}




