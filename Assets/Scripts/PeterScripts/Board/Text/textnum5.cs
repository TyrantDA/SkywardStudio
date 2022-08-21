using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class textnum5 : MonoBehaviour
{
    public GameObject rob1;
    public int num = 1;
    public Text showid;
    public bool try1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        showid.text = num.ToString();

        if (rob1 == false)
        {
            if (try1 == false)
            {
                try1 = true;
                num = num - 1;

            }

        }

    }
}
