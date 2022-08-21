using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class abitycooldown : MonoBehaviour
{
    public Playertilemover player;

    public Text firenum;
    public GameObject fireballim;
    public GameObject fireballim2;

    public Text pushnum;
    public GameObject pushim;
    public GameObject pushim2;

    public Text hitnum;
    public GameObject hitim;
    public GameObject hitim2;

    public Text slashnum;
    public GameObject slashim;
    public GameObject slashim2;

    public Text dashnum;
    public GameObject dashim;
    public GameObject dashim2;

    public GameObject bashing1;
    public GameObject bashing2;

    public GameObject fireing1;
    public GameObject fireing2;

    public GameObject hitiing1;
    public GameObject hitiing2;

    public GameObject slashing1;
    public GameObject slashing2;
    public GameObject dashing1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.bashtrue == true)
        {
            if (player.bashcango == true)
            {
                bashing1.SetActive(false);
                bashing2.SetActive(true);
            }
            else
            {
                bashing1.SetActive(true);
                bashing2.SetActive(false);
            }
            if (player.pushwait > 0)
            {
                pushim.SetActive(false);
                pushim2.SetActive(true);
                pushnum.text = player.pushwait.ToString();
            }
            else
            {
                pushim.SetActive(true);
                pushim2.SetActive(false);
                pushnum.text = null;
            }
        }
        if (player.fireture == true)
        {
            if (player.Fireballcango == true)
            {
                fireing1.SetActive(false);
                fireing2.SetActive(true);
            }
            else
            {
                fireing1.SetActive(true);
                fireing2.SetActive(false);
            }
            if (player.fireballwait > 0)
            {
                fireballim.SetActive(false);
                fireballim2.SetActive(true);
                firenum.text = player.fireballwait.ToString();
            }
            else
            {
                fireballim.SetActive(true);
                fireballim2.SetActive(false);
                firenum.text = null;
            }
        }
        if (player.hittrue == true)
        {
            if (player.hitcango == true)
            {
                hitiing1.SetActive(false);
                hitiing2.SetActive(true);
            }
            else
            {
                hitiing1.SetActive(true);
                hitiing2.SetActive(false);
            }
            if (player.hitwait > 0)
            {
                hitim.SetActive(false);
                hitim2.SetActive(true);
                hitnum.text = player.hitwait.ToString();
            }
            else
            {
                hitim.SetActive(true);
                hitim2.SetActive(false);
                hitnum.text = null;
            }
        }
        if (player.slashtrue == true)
        {
            if (player.Slashcango == true)
            {
                slashing1.SetActive(false);
                slashing2.SetActive(true);
            }
            else
            {
                slashing1.SetActive(true);
                slashing2.SetActive(false);
            }
            if (player.slashwait > 0)
            {
                slashim.SetActive(false);
                slashim2.SetActive(true);
                slashnum.text = player.slashwait.ToString();
            }
            else
            {
                slashim.SetActive(true);
                slashim2.SetActive(false);
                slashnum.text = null;
            }
        }

        if (player.dashtrue == true)
        {
            dashing1.SetActive(true);

            if (player.dashwait > 0)
            {
                dashim.SetActive(false);
                dashim2.SetActive(true);
                dashnum.text = player.dashwait.ToString();
            }
            else
            {
                dashim.SetActive(true);
                dashim2.SetActive(false);
                dashnum.text = null;
            }
        }







    }
}
