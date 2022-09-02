using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class textapp6 : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;

    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;

    public GameObject im1;
    public GameObject im2;
    public GameObject im3;

    public GameObject im4;
    public GameObject en1;
    public float xing;
    public float zing;
    public bool done;
    public GameObject mod;
    public Playertilemover player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (en1 != null)
        {
            if (en1.GetComponent<EnemyHealth>().health != 0)
            {
                xing = en1.transform.position.x - 1;
                zing = en1.transform.position.z - 1;

            }

        }
        if (text1.GetComponent<Textappear>().done == true)
        {
            text2.SetActive(true);
        }
        if (text2.GetComponent<Textappear>().done == true)
        {
            text3.SetActive(true);
        }
        if (text3.GetComponent<Textappear>().done == true&& player.move>=8)
        {
            text3.SetActive(false);
            text2.SetActive(false);
            text1.SetActive(false);
            text4.SetActive(true);

        }
        if (text4.GetComponent<Textappear>().done == true)
        {
            im1.SetActive(true);

            text5.SetActive(true);
        }
        if (text5.GetComponent<Textappear>().done == true)
        {
            im2.SetActive(true);
            im3.SetActive(true);
            im4.SetActive(true);

            text6.SetActive(true);
        }
        if(en1 == null)
        {
            if(done== false)
            {
                done = true;
                var newSquare = Instantiate(mod, new Vector3(xing, 1, zing), Quaternion.identity);

            }
            im1.SetActive(false);
            text4.SetActive(false);

            text5.SetActive(false);
            im2.SetActive(false);
            im3.SetActive(false);
            im4.SetActive(false);

            text6.SetActive(false);
            StartCoroutine("wait");

            text7.SetActive(true);
        }
    }
    public IEnumerator wait()
    {

        yield return new WaitForSeconds(10);

        SceneManager.LoadScene("Tutorial 4.8");

    }
}
