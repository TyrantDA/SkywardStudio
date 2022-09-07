using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCheck : MonoBehaviour
{
    [SerializeField] List<ItemInfo> keyList = new List<ItemInfo>();
    [SerializeField] List<int> KeyAmount = new List<int>();

    [SerializeField] List<Animator>  AnimatorList = new List<Animator>();
    public string setName;
    public Text doesNotHaveFortKey;
    public AudioSource noice;

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
                for(int x = 0; x < AnimatorList.Count; x++)
                {
                    Debug.Log("done");
                    AnimatorList[x].SetTrigger(setName);
                    noice.Play();
                }
            }
            else
            {
                doesNotHaveFortKey.gameObject.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            doesNotHaveFortKey.gameObject.SetActive(false);
        }

    }
}
