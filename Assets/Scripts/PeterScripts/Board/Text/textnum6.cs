using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class textnum6 : MonoBehaviour
{
    public GameObject rob1;
    public GameObject rob2;
    public GameObject rob3;
    public GameObject rob4;
    public bool try1;
    public bool try2;
    public bool try3;
    public bool try4;
    public int num = 4;
    public Text showid;

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
        if (rob2 == false)
        {
            if (try2 == false)
            {
                try2 = true;
                num = num - 1;

            }
        }
        if (rob3 == false)
        {
            if (try3 == false)
            {
                try3 = true;
                num = num - 1;

            }
        }
        if (rob4 == false)
        {
            if (try4 == false)
            {
                try4 = true;
                num = num - 1;

            }
        }

    }
}
