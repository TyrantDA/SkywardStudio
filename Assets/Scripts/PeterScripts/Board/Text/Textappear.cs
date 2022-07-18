using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Textappear : MonoBehaviour
{
    public float delay = 0.1f;
    public string fulltext;
    private string currenttext = "";
    public bool done;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("showtext");
    }
    IEnumerator showtext()
    {
        for (int i = 0; i < fulltext.Length; i++)
        {
            currenttext = fulltext.Substring(0, i);
            this.GetComponent<Text>().text = currenttext;
            yield return new WaitForSeconds(delay);
        }
        done = true;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
