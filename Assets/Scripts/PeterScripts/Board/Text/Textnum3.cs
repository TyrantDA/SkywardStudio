using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Textnum3 : MonoBehaviour
{
    public GameObject rob1;
    public GameObject rob2;
    public GameObject rob3;
    public GameObject rob4;
    public GameObject rob5;
    public GameObject rob6;
    public GameObject rob7;
    public GameObject rob8;
    public GameObject rob9;
    public GameObject rob10;
    public GameObject rob11;
    public GameObject rob12;
    public GameObject rob13;
    public GameObject rob14;
    public GameObject rob15;
    public GameObject rob16;
    public bool try1;
    public bool try2;
    public bool try3;
    public bool try4;
    public bool try5;
    public bool try6;
    public bool try7;
    public bool try8;
    public bool try9;
    public bool try10;
    public bool try11;
    public bool try12;
    public bool try13;
    public bool try14;
    public bool try15;
    public bool try16;

    public int num = 16;
    public Text showid;

    // Start is called before the first frame update
    void Start()
    {
        num = 16;

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
        if (rob9 == false)
        {
            if (try9 == false)
            {
                try9 = true;
                num = num - 1;

            }
        }
        if (rob10 == false)
        {
            if (try10 == false)
            {
                try10 = true;
                num = num - 1;

            }
        }
        if (rob11 == false)
        {
            if (try11 == false)
            {
                try11 = true;
                num = num - 1;

            }

        }
        if (rob12 == false)
        {
            if (try12 == false)
            {
                try12 = true;
                num = num - 1;

            }
        }
        if (rob13 == false)
        {
            if (try13 == false)
            {
                try13 = true;
                num = num - 1;

            }
        }
        if (rob14 == false)
        {
            if (try14 == false)
            {
                try14 = true;
                num = num - 1;

            }
        }
        if (rob15 == false)
        {
            if (try15 == false)
            {
                try15 = true;
                num = num - 1;

            }
        }
        if (rob16 == false)
        {
            if (try16 == false)
            {
                try16 = true;
                num = num - 1;

            }
        }
    }
}
