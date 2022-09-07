using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemListUI : MonoBehaviour
{
    public GameObject panelContainer;
    public Transform coinPoint;
    public GameObject uiItemPrefab;
    public GameObject uiCoin;
    public int addAmount = 1;
    public ItemInfo collectables;
    public ItemInfo key;

    Dictionary<ItemInfo, int> items = new Dictionary<ItemInfo, int>();
    Dictionary<ItemInfo, UIItem> uiItems = new Dictionary<ItemInfo, UIItem>();

    int coinAmount = 0;
    GameObject coinStore;

    public void AddItemButton(ItemInfo newItem)
    {
        AddItem(newItem, addAmount);
    }

    public void AddItem(ItemInfo newItem, int amount = 1)
    {
        //Debug.Log("The amount added " + amount);
        if (!items.ContainsKey(newItem))
        {
            if (amount < 1)
                return;
            items.Add(newItem, amount);
            uiItems.Add(newItem, Instantiate(uiItemPrefab, panelContainer.transform).GetComponent<UIItem>());
            uiItems[newItem].SetItem(newItem, items[newItem]);
        }
        else
        {
            items[newItem] += amount;

            if (items[newItem] <= 0)
            {
                items.Remove(newItem);
                Destroy(uiItems[newItem].gameObject);
                uiItems.Remove(newItem);
            }
            else
            {
                uiItems[newItem].SetItem(newItem, items[newItem]);
            }
        }
    }

    public void addCoin(int addAmount = 1)
    {
        if(coinAmount <= 0)
        {
            coinAmount += addAmount;

            if (coinAmount < 0)
                return;

            coinStore = Instantiate(uiCoin, coinPoint);
            coinStore.GetComponent<UIItem>().SetItem(coinAmount);
        }
        else
        {
            coinAmount += addAmount;

            if(coinAmount <= 0)
            {
                Destroy(coinStore);
            }
            else
            {
                coinStore.GetComponent<UIItem>().SetItem(coinAmount);
            }
        }
    }

    public int HasItem(ItemInfo myItem)
    {
        if (items.ContainsKey(myItem))
            return items[myItem];
        else
            return 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("running");
        if (other.gameObject.CompareTag("collectables"))
        {
            Debug.Log("collectables");
            Destroy(other.gameObject);
            AddItem(collectables);
        }

        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            addCoin();
        }

        if (other.gameObject.CompareTag("Key"))
        {
            Destroy(other.gameObject);
            AddItem(key);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("running");
        if (collision.gameObject.CompareTag("collectables"))
        {
            Debug.Log("collectables");
            Destroy(collision.gameObject);
            AddItem(collectables);
        }

        if(collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            addCoin();
        }

        if(collision.gameObject.CompareTag("Key"))
        {
            Destroy(collision.gameObject);
            AddItem(key);
        }
    }
}
