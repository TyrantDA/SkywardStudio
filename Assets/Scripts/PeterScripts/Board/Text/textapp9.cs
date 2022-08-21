using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class textapp9 : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject text8;

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
            text3.SetActive(true);
            text4.SetActive(true);
            text5.SetActive(true);
            text6.SetActive(true);
            text7.SetActive(true);
        }
        if (text2.GetComponent<textnum5>().num == 0 && text4.GetComponent<textnum6>().num == 0&& text6.GetComponent<textnum7>().num == 0)
        {
            text1.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
            text4.SetActive(false);
            text5.SetActive(false);
            text6.SetActive(false);
            text7.SetActive(false);
            StartCoroutine("wait");

            text8.SetActive(true);
        }

    }
    public IEnumerator wait()
    {

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene("Comabtmenue");

    }
}
