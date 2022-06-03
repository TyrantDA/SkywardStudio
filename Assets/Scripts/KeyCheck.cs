using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCheck : MonoBehaviour
{
    [SerializeField] List<ItemInfo> keyList = new List<ItemInfo>();
    [SerializeField] List<int> KeyAmount = new List<int>();

    public Component activateObject;

    bool checkRequirements(GameObject Player)
    {
        int hold = 0;
        for(int x = 0; x < keyList.Count; x++)
        {
            if(Player.GetComponent<ItemListUI>().HasItem(keyList[x]) == KeyAmount[x])
            {
                hold++;
            }
        }

        if (hold == keyList.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(checkRequirements(other.gameObject))
            {
            }
        }
    }
}
