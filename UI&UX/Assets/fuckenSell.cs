using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuckenSell : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject sellItem;
    private ShopManager shop;
    public ShopManager shopManager;
    public int price;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SellItem()
    {
        Transform childTransform = sellItem.transform.Find("Image(Clone)");
        if (childTransform != null)
        {
            // Child GameObject found
            GameObject childGameObject = childTransform.gameObject;
            Destroy(childGameObject);
           shopManager.Selling(price);
        }
    }
}
