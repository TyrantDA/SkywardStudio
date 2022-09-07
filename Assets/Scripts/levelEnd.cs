using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelEnd : MonoBehaviour
{
    public string level;
    public Text levelEndSoon;
    public ItemInfo collectables;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SetCursorState(bool newState)
    {
        Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
    }
    IEnumerator endLevel()
    {
        levelEndSoon.gameObject.SetActive(true);
        yield return new WaitForSeconds(20f);
        SceneManager.LoadScene(level);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        Debug.Log("detected");
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("collectable", other.gameObject.GetComponent<ItemListUI>().HasItem(collectables));
            SetCursorState(false);
            StartCoroutine("endLevel");

        }
    }
}
