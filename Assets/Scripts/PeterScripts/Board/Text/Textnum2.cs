using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Textnum2 : MonoBehaviour
{
    public GameObject rob1;
    public GameObject rob2;
    public GameObject rob3;
    public GameObject rob4;
    public GameObject rob5;
    public GameObject rob6;
    public GameObject rob7;
    public GameObject rob8;

    public bool try1;
    public bool try2;
    public bool try3;
    public bool try4;
    public bool try5;
    public bool try6;
    public bool try7;
    public bool try8;

    public int num=8;
    public Text showid;

    // Start is called before the first frame update
    void Start()
    {
        num = 8;

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
        if (rob5 == false)
        {
            if (try5 == false)
            {
                try5 = true;
                num = num - 1;

            }
        }
        if (rob6 == false)
        {
            if (try6 == false)
            {
                try6 = true;
                num = num - 1;

            }
        }
        if (rob7 == false)
        {
            if (try7 == false)
            {
                try7 = true;
                num = num - 1;

            }
        }
        if (rob8 == false)
        {
            if (try8 == false)
            {
                try8 = true;
                num = num - 1;

            }
        }
    }
}
