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
    public ItemInfo food;

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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Food"))
        {
            Destroy(collision.gameObject);
            AddItem(food);
        }

        if(collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            addCoin();
        }

        if(collision.gameObject.CompareTag("Key"))
        {
            AddItem(collision.gameObject.GetComponent<KeyHolder>().getKey());
            Destroy(collision.gameObject);
        }
    }
}
