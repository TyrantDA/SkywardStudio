using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Textapp5 : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;

    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;

    public GameObject mod;
    public GameObject tile;

    public GameObject wall;
    public bool prinited;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (text1.GetComponent<Textappear>().done == true)
        {
            text2.SetActive(true);
        }
        if (text2.GetComponent<Textappear>().done == true)
        {
            text3.SetActive(true);
            text4.SetActive(true);

        }
        if (text4.GetComponent<Textnum2>().num == 0)
        {
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(true);

        }
        if (text5.GetComponent<Textappear>().done == true)
        {
            text6.SetActive(true);
            wall.gameObject.SetActive(false);
            tile.GetComponent<Tilechangerwalk>().ocupided = false;
            if (prinited == false)
            {
                prinited = true;
                var newSquare = Instantiate(mod, new Vector3(5, 1, 7), Quaternion.identity);
                StartCoroutine("wait");

            }

        }

    }
    public IEnumerator wait()
    {

        yield return new WaitForSeconds(10);

        SceneManager.LoadScene("Tutorial 4");

    }
}
